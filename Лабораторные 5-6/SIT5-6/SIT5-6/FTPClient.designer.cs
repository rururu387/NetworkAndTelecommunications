namespace SIT_Lab5_6
{
    partial class FTPClient
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
            this.openHttpClient = new System.Windows.Forms.Button();
            this.downloadFileName = new System.Windows.Forms.TextBox();
            this.downloadFileLabel = new System.Windows.Forms.Label();
            this.downloadFolderPath = new System.Windows.Forms.TextBox();
            this.downloadFolderLabel = new System.Windows.Forms.Label();
            this.ftpResult = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.getFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openHttpClient
            // 
            this.openHttpClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.openHttpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.openHttpClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openHttpClient.Location = new System.Drawing.Point(11, 73);
            this.openHttpClient.Margin = new System.Windows.Forms.Padding(2);
            this.openHttpClient.Name = "openHttpClient";
            this.openHttpClient.Size = new System.Drawing.Size(160, 37);
            this.openHttpClient.TabIndex = 2;
            this.openHttpClient.Text = "HTTP клиент";
            this.openHttpClient.UseVisualStyleBackColor = false;
            this.openHttpClient.Click += new System.EventHandler(this.openHTTPClientClicked);
            // 
            // downloadFileName
            // 
            this.downloadFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFileName.Location = new System.Drawing.Point(307, 11);
            this.downloadFileName.Margin = new System.Windows.Forms.Padding(2);
            this.downloadFileName.Name = "downloadFileName";
            this.downloadFileName.Size = new System.Drawing.Size(282, 23);
            this.downloadFileName.TabIndex = 4;
            // 
            // downloadFileLabel
            // 
            this.downloadFileLabel.AutoSize = true;
            this.downloadFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFileLabel.Location = new System.Drawing.Point(11, 14);
            this.downloadFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downloadFileLabel.Name = "downloadFileLabel";
            this.downloadFileLabel.Size = new System.Drawing.Size(292, 17);
            this.downloadFileLabel.TabIndex = 6;
            this.downloadFileLabel.Text = "Адрес файла в формате ftp://<IPv4-адрес>/";
            // 
            // downloadFolderPath
            // 
            this.downloadFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFolderPath.Location = new System.Drawing.Point(107, 46);
            this.downloadFolderPath.Margin = new System.Windows.Forms.Padding(2);
            this.downloadFolderPath.Name = "downloadFolderPath";
            this.downloadFolderPath.Size = new System.Drawing.Size(451, 23);
            this.downloadFolderPath.TabIndex = 7;
            // 
            // downloadFolderLabel
            // 
            this.downloadFolderLabel.AutoSize = true;
            this.downloadFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadFolderLabel.Location = new System.Drawing.Point(11, 49);
            this.downloadFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downloadFolderLabel.Name = "downloadFolderLabel";
            this.downloadFolderLabel.Size = new System.Drawing.Size(92, 17);
            this.downloadFolderLabel.TabIndex = 8;
            this.downloadFolderLabel.Text = "Сохранить в:";
            // 
            // ftpResult
            // 
            this.ftpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftpResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ftpResult.Location = new System.Drawing.Point(11, 115);
            this.ftpResult.Margin = new System.Windows.Forms.Padding(2);
            this.ftpResult.Multiline = true;
            this.ftpResult.Name = "ftpResult";
            this.ftpResult.Size = new System.Drawing.Size(578, 242);
            this.ftpResult.TabIndex = 9;
            // 
            // selectFolder
            // 
            this.selectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFolder.Location = new System.Drawing.Point(562, 46);
            this.selectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(27, 25);
            this.selectFolder.TabIndex = 12;
            this.selectFolder.Text = "...";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolderClicked);
            // 
            // getFile
            // 
            this.getFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.getFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.getFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getFile.Location = new System.Drawing.Point(444, 74);
            this.getFile.Margin = new System.Windows.Forms.Padding(2);
            this.getFile.Name = "getFile";
            this.getFile.Size = new System.Drawing.Size(145, 37);
            this.getFile.TabIndex = 13;
            this.getFile.Text = "Скачать файл";
            this.getFile.UseVisualStyleBackColor = false;
            this.getFile.Click += new System.EventHandler(this.getFileClicked);
            // 
            // FTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.openHttpClient);
            this.Controls.Add(this.getFile);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.ftpResult);
            this.Controls.Add(this.downloadFolderLabel);
            this.Controls.Add(this.downloadFolderPath);
            this.Controls.Add(this.downloadFileLabel);
            this.Controls.Add(this.downloadFileName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FTPClient";
            this.Text = "FTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox downloadFileName;
        private System.Windows.Forms.Label downloadFileLabel;
        private System.Windows.Forms.TextBox downloadFolderPath;
        private System.Windows.Forms.Label downloadFolderLabel;
        private System.Windows.Forms.TextBox ftpResult;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Button getFile;
        private System.Windows.Forms.Button openHttpClient;
    }
}