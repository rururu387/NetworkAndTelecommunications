using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SIT_Lab5_6
{
    public partial class HTTPClient : Form
    {
        public HTTPClient()
        {
            InitializeComponent();
        }

        private void showWarning(String warningMeessage)
        {
            MessageBox.Show(warningMeessage, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void showError(String errorMessage)
        {
            MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void openFTPClientClicked(object sender, EventArgs e)
        {
            FTPClient ftpClient = new FTPClient();
            ftpClient.Show();
            this.Hide();
        }

        private void queryClicked(object sender, EventArgs e)
        {
            httpResult.Clear();
            httpResult.Text = DateTime.Now.ToString("HH:mm:ss.f") + " загрузка начинается\r\n";
            string url = httpAddress.Text;
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    httpResult.Text += DateTime.Now.ToString("HH:mm:ss.f") + " отправка запроса\r\n";
                    HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                    request.Method = "GET";

                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    httpResult.Text += DateTime.Now.ToString("HH:mm:ss.f") + " запрос отправлен, получен ответ\r\n";
                    string encoding = "utf-8";
                    string contentType = response.Headers["Content-Type"];

                    if (contentType != null)
                    {
                        encoding = contentType.Substring(contentType.IndexOf("charset=") + 8);
                    }

                    StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                    httpResult.Text += httpResult.Text + DateTime.Now.ToString("HH:mm:ss.f") + " инициализация потока данных ответа\r\n";
                    httpResult.Text += "==============================================\r\n";

                    httpResult.Text += streamReader.ReadToEnd();
                    httpResult.Text += "==============================================\r\n";
                    streamReader.Close();
                }
                catch
                {
                    showError("Запрос не выполнен. Убедитесь в правильности ссылки");
                }
            }
            else
            {
                showWarning("Введите адрес для запроса");
            }
        }
    }
}
