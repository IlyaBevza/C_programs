/*
 * Дата: 17.06.2018
 * Время: 17:43
 */
using System;
using System.Net;
using System.Text;
using System.IO;

namespace Assist
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			if(args.Length!=3) return;
			string path=args[0];
			string url=args[1];
			string data=args[2];
			string response=POST(url,data);
			if(response==string.Empty) return;
			using (FileStream file=new FileStream(path,FileMode.Create)){
				byte[] bytedata=Encoding.UTF8.GetBytes(response);
				file.Write(bytedata,0,bytedata.Length);
				};
			
		}
		


private static string POST(string Url, string Data)
{
	ServicePointManager.SecurityProtocol=SecurityProtocolType.Tls11;
	
	WebRequest req = WebRequest.Create(Url);
  req.Method = "POST";
  req.Timeout = 100000;
  req.ContentType = "application/x-www-form-urlencoded";
  byte[] sentData = Encoding.UTF8.GetBytes(Data);
  req.ContentLength = sentData.Length;
  using(Stream sendStream = req.GetRequestStream()){
  	sendStream.Write(sentData, 0, sentData.Length);
  };
  WebResponse response = req.GetResponse();
  using (Stream stream = response.GetResponseStream())
    {
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }
}

	}
}