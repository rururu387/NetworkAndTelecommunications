using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SIT_Lab7_8
{
    public partial class SMTP : Form
    {
        public SMTP()
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

        public async Task sendEmail()
        {
            if (!IsValidEmail(mailLogin.Text) || mailPassword.Text == "" || !IsValidEmail(destination.Text) || mailServer.Text == "")
            {
                showWarning("Заполните необходимые для отправки данные корректно.\nОбязательно заполнять: свой почтовый адрес, пароль, почтовый сервер и адрес получателя.");
                return;
            }

            try
            {
                MailAddress fromAddress = new MailAddress(mailLogin.Text, mailLogin.Text.Split('@').First());
                MailAddress toAddress = new MailAddress(destination.Text);
                MailMessage message = new MailMessage(fromAddress, toAddress);
                message.Subject = issue.Text;
                message.Body = this.messageInput.Text;
                SmtpClient smtpClient = new SmtpClient(mailServer.Text, 587);
                smtpClient.Credentials = new NetworkCredential(mailLogin.Text, mailPassword.Text);
                smtpClient.EnableSsl = true;
                await smtpClient.SendMailAsync(message);
            }
            catch (Exception ex)
            {
                showError("Сообщение не было отправлено: " + ex.Message);
            }

            showWarning("Письмо отправлено");
        }

        private void send_Click(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void toIncomingMessagesClicked(object sender, EventArgs e)
        {
            POP3 pop3 = new POP3();
            this.Hide();
            pop3.Show();

        }
    }
}
