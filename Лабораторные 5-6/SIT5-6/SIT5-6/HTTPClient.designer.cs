namespace SIT_Lab5_6
{
    partial class HTTPClient
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFtpClient = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.Button();
            this.httpResult = new System.Windows.Forms.TextBox();
            this.downloadFileLabel = new System.Windows.Forms.Label();
            this.httpAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFtpClient
            // 
            this.openFtpClient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openFtpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFtpClient.Location = new System.Drawing.Point(11, 38);
            this.openFtpClient.Margin = new System.Windows.Forms.Padding(2);
            this.openFtpClient.Name = "openFtpClient";
            this.openFtpClient.Size = new System.Drawing.Size(156, 35);
            this.openFtpClient.TabIndex = 0;
            this.openFtpClient.Text = "FTP клиент";
            this.openFtpClient.UseVisualStyleBackColor = false;
            this.openFtpClient.Click += new System.EventHandler(this.openFTPClientClicked);
            // 
            // query
            // 
            this.query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.query.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query.Location = new System.Drawing.Point(482, 38);
            this.query.Margin = new System.Windows.Forms.Padding(2);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(110, 38);
            this.query.TabIndex = 2;
            this.query.Text = "Запрос";
            this.query.UseVisualStyleBackColor = false;
            this.query.Click += new System.EventHandler(this.queryClicked);
            // 
            // httpResult
            // 
            this.httpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.httpResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.httpResult.Location = new System.Drawing.Point(11, 80);
            this.httpResult.Margin = new System.Windows.Forms.Padding(2);
            this.httpResult.Multiline = true;
            this.httpResult.Name = "httpResult";
            this.httpResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.httpResult.Size = new System.Drawing.Size(581, 277);
            this.httpResult.TabIndex = 3;
            // 
            // downloadFileLabel
            // 
            this.downloadFileLabel.AutoSize = true;
            this.downloadFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFileLabel.Location = new System.Drawing.Point(11, 14);
            this.downloadFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downloadFileLabel.Name = "downloadFileLabel";
            this.downloadFileLabel.Size = new System.Drawing.Size(116, 17);
            this.downloadFileLabel.TabIndex = 7;
            this.downloadFileLabel.Text = "Адрес страницы";
            // 
            // httpAddress
            // 
            this.httpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.httpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.httpAddress.Location = new System.Drawing.Point(131, 11);
            this.httpAddress.Margin = new System.Windows.Forms.Padding(2);
            this.httpAddress.Name = "httpAddress";
            this.httpAddress.Size = new System.Drawing.Size(461, 23);
            this.httpAddress.TabIndex = 8;
            // 
            // HTTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.httpAddress);
            this.Controls.Add(this.downloadFileLabel);
            this.Controls.Add(this.openFtpClient);
            this.Controls.Add(this.httpResult);
            this.Controls.Add(this.query);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HTTPClient";
            this.Text = "HTTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFtpClient;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.TextBox httpResult;
        private System.Windows.Forms.Label downloadFileLabel;
        private System.Windows.Forms.TextBox httpAddress;
    }
}

