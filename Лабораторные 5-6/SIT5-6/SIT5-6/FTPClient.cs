using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace SIT_Lab5_6
{
    public partial class FTPClient : Form
    {
        private string fileName;
        private static string server = "";

        public FTPClient()
        {
            InitializeComponent();
            downloadFileLabel.Text = downloadFileLabel.Text + server;
        }

        private void showWarning(String warningMeessage)
        {
            MessageBox.Show(warningMeessage, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void showError(String errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void openHTTPClientClicked(object sender, EventArgs e)
        {
            HTTPClient httpClient = new HTTPClient();
            httpClient.Show();
            this.Hide();
        }

        private void selectFolderClicked(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    downloadFolderPath.Text = selectedPath;
                }
            }
        }

        private void getFileClicked(object sender, EventArgs e)
        {
            ftpResult.Clear();
            ftpResult.Text = DateTime.Now.ToString("HH:mm:ss.f") + " загрузка начинается\r\n";
            string fileURL = downloadFileName.Text;
            fileName = downloadFileName.Text.Split('/').Last();

            if (fileURL == "" || fileName == "")
            {
                showWarning("Введите название файла");
            }
            else
            {
                if (downloadFolderPath.Text == "")
                {
                    showWarning("Выберите папку");
                }
                else
                {
                    try
                    {
                        ftpResult.Text += ftpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " отправка запроса\r\n";
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server + fileURL);
                        request.Method = WebRequestMethods.Ftp.DownloadFile;

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        ftpResult.Text += ftpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " запрос отправлен, получен ответ\r\n";
                        Stream responseStream = response.GetResponseStream();
                        ftpResult.Text += ftpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " инициализация потока данных ответа\r\n";

                        FileStream fs = new FileStream(downloadFolderPath.Text + "\\" + fileName, FileMode.Create);
                        ftpResult.Text += ftpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " инициализация файлового потока для сохранения\r\n";
                        byte[] buffer = new byte[64];
                        int size = 0;

                        while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fs.Write(buffer, 0, size);
                        }

                        fs.Close();
                        response.Close();
                        ftpResult.Text += ftpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " загрузка завершена\r\n";
                    }
                    catch
                    {
                        showError("Ошибка загрузки файла");
                    }
                }
            }
        }
    }
}
