namespace ChatSystem
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxServers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerChat = new System.Windows.Forms.TextBox();
            this.txtUserMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnChoseServer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxServers
            // 
            this.ListBoxServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxServers.FormattingEnabled = true;
            this.ListBoxServers.Location = new System.Drawing.Point(0, 39);
            this.ListBoxServers.Name = "ListBoxServers";
            this.ListBoxServers.Size = new System.Drawing.Size(109, 485);
            this.ListBoxServers.TabIndex = 0;
            this.ListBoxServers.Click += new System.EventHandler(this.SelectItemListBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(60, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(0, 13);
            this.txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servers:";
            // 
            // txtServerChat
            // 
            this.txtServerChat.AcceptsReturn = true;
            this.txtServerChat.Location = new System.Drawing.Point(116, 39);
            this.txtServerChat.Multiline = true;
            this.txtServerChat.Name = "txtServerChat";
            this.txtServerChat.ReadOnly = true;
            this.txtServerChat.Size = new System.Drawing.Size(950, 486);
            this.txtServerChat.TabIndex = 4;
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.Location = new System.Drawing.Point(116, 532);
            this.txtUserMessage.Multiline = true;
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.Size = new System.Drawing.Size(814, 97);
            this.txtUserMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(937, 532);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 97);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnChoseServer
            // 
            this.btnChoseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoseServer.Location = new System.Drawing.Point(0, 532);
            this.btnChoseServer.Name = "btnChoseServer";
            this.btnChoseServer.Size = new System.Drawing.Size(109, 97);
            this.btnChoseServer.TabIndex = 7;
            this.btnChoseServer.Text = "ChoseServer";
            this.btnChoseServer.UseVisualStyleBackColor = true;
            this.btnChoseServer.Click += new System.EventHandler(this.btnChoseServer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(991, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 641);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChoseServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.txtServerChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxServers);
            this.Name = "ChatForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerChat;
        private System.Windows.Forms.TextBox txtUserMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnChoseServer;
        private System.Windows.Forms.Button btnLogout;
    }
}

