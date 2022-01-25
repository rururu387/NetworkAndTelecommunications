namespace SIT_Lab7_8
{
    partial class POP3
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
            this.sendMessage = new System.Windows.Forms.Button();
            this.messagesView = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTextLabel = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.mailLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.mailServer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messagesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // sendMessage
            // 
            this.sendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sendMessage.Location = new System.Drawing.Point(420, 396);
            this.sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(153, 54);
            this.sendMessage.TabIndex = 7;
            this.sendMessage.Text = "Ответить / Написать";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendButtonClicked);
            // 
            // messagesView
            // 
            this.messagesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.messagesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.Sender,
            this.Date,
            this.messBody});
            this.messagesView.Location = new System.Drawing.Point(11, 74);
            this.messagesView.Margin = new System.Windows.Forms.Padding(2);
            this.messagesView.Name = "messagesView";
            this.messagesView.RowHeadersVisible = false;
            this.messagesView.RowHeadersWidth = 51;
            this.messagesView.RowTemplate.Height = 24;
            this.messagesView.Size = new System.Drawing.Size(562, 232);
            this.messagesView.TabIndex = 5;
            this.messagesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesCellClicked);
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Тема";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.Width = 150;
            // 
            // Sender
            // 
            this.Sender.HeaderText = "Отправитель";
            this.Sender.MinimumWidth = 6;
            this.Sender.Name = "Sender";
            this.Sender.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // messBody
            // 
            this.messBody.HeaderText = "Начало сообщения";
            this.messBody.MinimumWidth = 6;
            this.messBody.Name = "messBody";
            this.messBody.Width = 175;
            // 
            // messageTextLabel
            // 
            this.messageTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextLabel.AutoSize = true;
            this.messageTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageTextLabel.Location = new System.Drawing.Point(8, 319);
            this.messageTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageTextLabel.Name = "messageTextLabel";
            this.messageTextLabel.Size = new System.Drawing.Size(188, 18);
            this.messageTextLabel.TabIndex = 2;
            this.messageTextLabel.Text = "Полный текст сообщения";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message.Location = new System.Drawing.Point(11, 339);
            this.message.Margin = new System.Windows.Forms.Padding(2);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(405, 111);
            this.message.TabIndex = 6;
            // 
            // mailLogin
            // 
            this.mailLogin.Location = new System.Drawing.Point(137, 9);
            this.mailLogin.Name = "mailLogin";
            this.mailLogin.Size = new System.Drawing.Size(169, 20);
            this.mailLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Почтовый адрес";
            // 
            // mailPassword
            // 
            this.mailPassword.Location = new System.Drawing.Point(137, 44);
            this.mailPassword.Name = "mailPassword";
            this.mailPassword.Size = new System.Drawing.Size(169, 20);
            this.mailPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Почтовый сервер";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // mailServer
            // 
            this.mailServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailServer.Location = new System.Drawing.Point(447, 9);
            this.mailServer.Name = "mailServer";
            this.mailServer.Size = new System.Drawing.Size(125, 20);
            this.mailServer.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(396, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Получить сообщения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.recieveButtonClicked);
            // 
            // POP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messageTextLabel);
            this.Controls.Add(this.messagesView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "POP3";
            ((System.ComponentModel.ISupportInitialize)(this.messagesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView messagesView;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Label messageTextLabel;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn messBody;
        private System.Windows.Forms.TextBox mailLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailPassword;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox mailServer;
        private System.Windows.Forms.Button button1;
    }
}