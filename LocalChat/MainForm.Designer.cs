namespace OS2_Chat
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.buttonNickname = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.BackColor = System.Drawing.Color.RoyalBlue;
            this.richTextBoxChat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxChat.ForeColor = System.Drawing.Color.White;
            this.richTextBoxChat.Location = new System.Drawing.Point(8, 46);
            this.richTextBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.ReadOnly = true;
            this.richTextBoxChat.Size = new System.Drawing.Size(686, 579);
            this.richTextBoxChat.TabIndex = 0;
            this.richTextBoxChat.Text = "";
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.Red;
            this.buttonSendMessage.Enabled = false;
            this.buttonSendMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSendMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(524, 629);
            this.buttonSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(169, 121);
            this.buttonSendMessage.TabIndex = 1;
            this.buttonSendMessage.Text = "→";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMessage.Enabled = false;
            this.textBoxMessage.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.ForeColor = System.Drawing.Color.White;
            this.textBoxMessage.Location = new System.Drawing.Point(9, 629);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.PlaceholderText = " Сообщение";
            this.textBoxMessage.Size = new System.Drawing.Size(512, 121);
            this.textBoxMessage.TabIndex = 2;
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxNickname.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxNickname.ForeColor = System.Drawing.Color.White;
            this.textBoxNickname.Location = new System.Drawing.Point(230, 7);
            this.textBoxNickname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNickname.Multiline = true;
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.PlaceholderText = "Имя";
            this.textBoxNickname.Size = new System.Drawing.Size(290, 35);
            this.textBoxNickname.TabIndex = 3;
            this.textBoxNickname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNickname_KeyPress);
            // 
            // buttonNickname
            // 
            this.buttonNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNickname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNickname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonNickname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNickname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonNickname.ForeColor = System.Drawing.Color.White;
            this.buttonNickname.Location = new System.Drawing.Point(524, 7);
            this.buttonNickname.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNickname.Name = "buttonNickname";
            this.buttonNickname.Size = new System.Drawing.Size(169, 35);
            this.buttonNickname.TabIndex = 5;
            this.buttonNickname.Text = "Подтвердить";
            this.buttonNickname.UseVisualStyleBackColor = false;
            this.buttonNickname.Click += new System.EventHandler(this.buttonNickname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите своё имя";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(706, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNickname);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.richTextBoxChat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(722, 800);
            this.MinimumSize = new System.Drawing.Size(722, 800);
            this.Name = "MainForm";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxChat;
        private Button buttonSendMessage;
        private TextBox textBoxMessage;
        private TextBox textBoxNickname;
        private Button buttonNickname;
        private Label label1;
    }
}