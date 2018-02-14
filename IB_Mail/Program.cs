
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace IB_Mail
{
	public class Mail
	{
			/// <summary>
		/// Отправка письма на почтовый ящик C# mail send
		/// </summary>
		/// <param name="smtpServer">Имя SMTP-сервера</param>
		/// <param name="from">Адрес отправителя</param>
		/// <param name="password">пароль к почтовому ящику отправителя</param>
		/// <param name="mailto">Адрес получателя</param>
		/// <param name="caption">Тема письма</param>
		/// <param name="message">Сообщение</param>
		/// <param name="attachFile">Присоединенный файл</param>
		public  void SendMail(string message,string[] args, string afrom="robot-1C@fguppromservis.ru",string attachFile = null)
		{
		try
		{
		MailMessage mail = new MailMessage();
		mail.From = new MailAddress(afrom);
		mail.To.Add(new MailAddress(args[3]));
		mail.Subject = "Отчет о файлах бэкапа";
		mail.Body = message;
		mail.IsBodyHtml=true;
		if (!string.IsNullOrEmpty(attachFile))
		mail.Attachments.Add(new Attachment(attachFile));
		SmtpClient client = new SmtpClient();
		client.Host = args[1];
		client.Port = 587;
		client.EnableSsl = true;
		client.Credentials = new NetworkCredential(afrom.Split('@')[0], args[2]);
		client.DeliveryMethod = SmtpDeliveryMethod.Network;
		ServicePointManager.ServerCertificateValidationCallback = RemoteCertificateValidationCallback;
		client.Send(mail);
		mail.Dispose();
		}
		catch (Exception e)
		{
		throw new Exception("Mail.Send: " + e.Message);
		}
		}
		 bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)

        {

            return true;

        }
	}
}