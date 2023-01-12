using NLog;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace OS2_Chat
{
    public class Chat
    {
        public event EventHandler<ReceiveMessageEventArgs> GetCurrentMessage;
        Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private static Logger logger = LogManager.GetCurrentClassLogger();

        UdpClient client = new UdpClient();
        CancellationTokenSource cancelTokenSource;
        CancellationToken token;
        
        public async void RecieveMessages()
        {
            IPEndPoint endPoint;
            try
            {
                if (config.AppSettings.Settings["recieve_ip"].Value == "" && config.AppSettings.Settings["port"].Value == "")
                    endPoint = new IPEndPoint(IPAddress.Any, 5555);
                else
                    endPoint = new IPEndPoint(IPAddress.Parse(config.AppSettings.Settings["recieve_ip"].Value),
                        Convert.ToInt32(config.AppSettings.Settings["port"].Value));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                endPoint = new IPEndPoint(IPAddress.Any, 5555);
            }

            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.Client.Bind(endPoint);
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
            while (true)
            {
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
                try
                {
                    var result = await client.ReceiveAsync(token);
                    var recieve_message = Encoding.UTF8.GetString(result.Buffer);
                    int index = recieve_message.IndexOf("|");
                    string user = "", message = "";
                    for (int i = 0; i < recieve_message.Length; i++)
                    {
                        if (i < index)
                            user += recieve_message[i];
                        if (i > index)
                            message += recieve_message[i];
                    }
                    GetCurrentMessage?.Invoke(this, new ReceiveMessageEventArgs { User = user, Message = message });
                }
                catch (Exception ex) 
                {
                    logger.Error(ex);
                    Environment.Exit(1); 
                }
            }
        }
        public void SendMessage(string message, string user)
        {
            string send_message = user + "|" + message;

            IPEndPoint endPoint;
            try
            {
                if (config.AppSettings.Settings["send_ip"].Value == "" && config.AppSettings.Settings["port"].Value == "")
                    endPoint = new IPEndPoint(IPAddress.Any, 5555);
                else
                    endPoint = new IPEndPoint(IPAddress.Parse(config.AppSettings.Settings["send_ip"].Value),
                        Convert.ToInt32(config.AppSettings.Settings["port"].Value));
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                endPoint = new IPEndPoint(IPAddress.Any, 5555);
            }

            endPoint = new IPEndPoint(IPAddress.Broadcast, 5555);
            byte[] data = Encoding.UTF8.GetBytes(send_message);
            client.SendAsync(data, endPoint);
        }
        public void CloseCon ()
        {
            if(cancelTokenSource != null)
                cancelTokenSource.Cancel(false);
            client.Close();
        }
    }
    public class ReceiveMessageEventArgs: EventArgs
    {
        public string User { set; get; }
        public string Message { set; get; }
    }
}
