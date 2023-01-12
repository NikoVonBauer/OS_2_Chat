using System;

namespace OS2_Chat
{
    public partial class MainForm : Form
    {
        private User user;
        Chat chat = new Chat();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNickname_Click(object sender, EventArgs e)
        {
            if (textBoxNickname.Text != "")
            {
                user = new User(textBoxNickname.Text);
                buttonNickname.Text = "Connected!";
                buttonNickname.BackColor = Color.White;
                textBoxNickname.Enabled = false;
                buttonNickname.Enabled = false;
                textBoxMessage.Enabled = true;
                buttonSendMessage.Enabled = true;

                chat.RecieveMessages();
                chat.GetCurrentMessage += Chat_RecieveMessage;
            }
        }

        private void Chat_RecieveMessage(object? sender, ReceiveMessageEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                richTextBoxChat.Text = richTextBoxChat.Text + DateTime.Now.ToString() + "\n" +
                       e.User + ": " + e.Message + "\n\n";
            }));
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string textUser = textBoxMessage.Text;

            if (textUser != "")
            {
                chat.SendMessage(textUser, user.Name);
                textBoxMessage.Clear();
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSendMessage_Click(sender, e);
                e.Handled = true;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            chat.CloseCon();
        }

        private void textBoxNickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonNickname_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}