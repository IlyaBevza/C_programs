
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Мониторинг_бэкапа
{
	class Program
	{
		// args: 0 -Родительская директория, 1 - smtp -server, 2- пароль почты отправителя , 3-  получатель
		public static void Main(string[] args)
		{	
			if (args.Length==0) return;
			string disk=args[0];
			
			StringBuilder html=new StringBuilder("<h3> Данные о файлах бэкапа </h3>");
			if(!Directory.Exists(disk)){

				html.AppendLine(string.Format("Папки {0}  не существует",disk));

			 }
			 string[] folders= Directory.GetDirectories(disk);
			 foreach (string folder in folders){
			 	DirectoryInfo dir=new DirectoryInfo(folder);

			 	html.AppendLine(string.Format("<p>Directory: {0}</br>",dir.Name));
			 	string[] backups=Directory.GetFiles(folder,"*.bak");
			 	html.AppendLine(string.Format("Всего файлов : {0}",backups.Length));
			 	DateTime[] drArray=new DateTime[backups.Length];
				for(int i=0;i<backups.Length;i++)
					drArray[i]=File.GetCreationTime(backups[i]);
				Array.Sort(drArray,backups); 
				if(backups.Length==0){
					html.AppendLine("<br><b> НИ ОДНОГО ФАЙЛА БЭКАПА НЕ НАЙДЕНО! </b>");
					SendMail(html.ToString(),args);
					return; 
				}
				string lastbackup=backups[backups.Length-1];
				html.AppendLine("<br> Последний созданный файл бэкапа: ");
				FileInfo bfile = new System.IO.FileInfo(lastbackup);
					html.AppendLine(string.Format("file: {0}, <b>создан</b> {1}, <b>размер</b> {2:0.##} ГБайт",bfile.Name,bfile.CreationTime.ToString(),bfile.Length/1048576.0));
			   	
			 	
			 }
			 SendMail(html.ToString(),args);
		}
		
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
		public static void SendMail(string message,string[] args, string attachFile = null)
		{
		try
		{
		MailMessage mail = new MailMessage();
		string afrom="robot-1C@fguppromservis.ru";
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
		static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)

        {

            return true;

        }
	}
	
}