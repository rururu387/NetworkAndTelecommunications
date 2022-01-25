using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace SIT_Lab7_8
{
    public partial class POP3 : Form
    {
        public POP3()
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

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void messagesCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (messagesView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                message.Text = messagesView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void recieveButtonClicked(object sender, EventArgs e)
        {
            if (!IsValidEmail(mailLogin.Text) || mailPassword.Text == "" || mailServer.Text == "")
            {
                showWarning("Заполните необходимые для отправки данные корректно.\nОбязательно заполнять: свой почтовый адрес, пароль и почтовый сервер.");
                return;
            }

            try
            {
                OpenPop.Pop3.Pop3Client POPClient = new OpenPop.Pop3.Pop3Client();
                POPClient.Connect(mailServer.Text, 995, true);
                POPClient.Authenticate(mailLogin.Text, mailPassword.Text);

                var count = POPClient.GetMessageCount();
                for (int i = 1; i <= count; i++)
                {
                    OpenPop.Mime.Message message = POPClient.GetMessage(i);
                    string subjectHeader = message.Headers.Subject;
                    string fromAddress = message.Headers.From.ToString();
                    string sendingDateTime = message.Headers.DateSent.ToString("MM/dd/yyyy HH:mm");

                    string messageBodyText = "";
                    if (!message.MessagePart.IsMultiPart)
                    {
                        messageBodyText = message.MessagePart.GetBodyAsText();
                    }

                    messagesView.Rows.Add(subjectHeader, fromAddress, sendingDateTime, messageBodyText);
                }
            }
            catch (ArgumentNullException nullArgumentException)
            {
                showError("Данные получены. Возникла ошибка при отображении. " + nullArgumentException.Message);
            }
            catch (InvalidOperationException invalidOperationException)
            {
                showError("Данные получены. Возникла ошибка при отображении. " + invalidOperationException.Message);
            }
            catch (Exception ex)
            {
                showError("Невозможно получить данные с сервера. " + ex.Message);
            }
        }

        private void sendButtonClicked(object sender, EventArgs e)
        {
            SMTP smtpWindow = new SMTP();
            smtpWindow.Show();
            this.Hide();
        }
    }
}
