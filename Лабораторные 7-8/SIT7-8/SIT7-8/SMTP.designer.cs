namespace SIT_Lab7_8
{
    partial class SMTP
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
            this.toIncomingMessages = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.issueLabel = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.TextBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.mailServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailPassword = new System.Windows.Forms.TextBox();
            this.mailLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toIncomingMessages
            // 
            this.toIncomingMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toIncomingMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.toIncomingMessages.Location = new System.Drawing.Point(11, 396);
            this.toIncomingMessages.Margin = new System.Windows.Forms.Padding(2);
            this.toIncomingMessages.Name = "toIncomingMessages";
            this.toIncomingMessages.Size = new System.Drawing.Size(153, 54);
            this.toIncomingMessages.TabIndex = 7;
            this.toIncomingMessages.Text = "Входящие";
            this.toIncomingMessages.UseVisualStyleBackColor = true;
            this.toIncomingMessages.Click += new System.EventHandler(this.toIncomingMessagesClicked);
            // 
            // destination
            // 
            this.destination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destination.Location = new System.Drawing.Point(60, 65);
            this.destination.Margin = new System.Windows.Forms.Padding(2);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(513, 24);
            this.destination.TabIndex = 4;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destinationLabel.Location = new System.Drawing.Point(11, 65);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(45, 18);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "Кому";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issueLabel.Location = new System.Drawing.Point(12, 96);
            this.issueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(44, 18);
            this.issueLabel.TabIndex = 3;
            this.issueLabel.Text = "Тема";
            // 
            // issue
            // 
            this.issue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issue.Location = new System.Drawing.Point(60, 93);
            this.issue.Margin = new System.Windows.Forms.Padding(2);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(513, 24);
            this.issue.TabIndex = 5;
            // 
            // messageInput
            // 
            this.messageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageInput.Location = new System.Drawing.Point(11, 133);
            this.messageInput.Margin = new System.Windows.Forms.Padding(2);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(562, 248);
            this.messageInput.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(420, 396);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(153, 54);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.send_Click);
            // 
            // mailServer
            // 
            this.mailServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailServer.Location = new System.Drawing.Point(448, 12);
            this.mailServer.Name = "mailServer";
            this.mailServer.Size = new System.Drawing.Size(125, 20);
            this.mailServer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Почтовый сервер";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Почтовый адрес";
            // 
            // mailPassword
            // 
            this.mailPassword.Location = new System.Drawing.Point(141, 38);
            this.mailPassword.Name = "mailPassword";
            this.mailPassword.Size = new System.Drawing.Size(166, 20);
            this.mailPassword.TabIndex = 2;
            // 
            // mailLogin
            // 
            this.mailLogin.Location = new System.Drawing.Point(141, 14);
            this.mailLogin.Name = "mailLogin";
            this.mailLogin.Size = new System.Drawing.Size(166, 20);
            this.mailLogin.TabIndex = 1;
            // 
            // SMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.mailPassword);
            this.Controls.Add(this.mailLogin);
            this.Controls.Add(this.mailServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toIncomingMessages);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.issueLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destination);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "SMTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.TextBox issue;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button toIncomingMessages;
        private System.Windows.Forms.TextBox mailServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailPassword;
        private System.Windows.Forms.TextBox mailLogin;
    }
}