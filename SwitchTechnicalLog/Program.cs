using System.IO;

namespace SwitchTechnicalLog
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			if(File.Exists(@"C:\Program Files\1cv8\conf\logcfg.xml"))
				File.Move(@"C:\Program Files\1cv8\conf\logcfg.xml",@"C:\Program Files\1cv8\conf\logcfgOFF.xml");
			else{
					if(File.Exists(@"C:\Program Files\1cv8\conf\logcfgOFF.xml"))
				File.Move(@"C:\Program Files\1cv8\conf\logcfgOFF.xml",@"C:\Program Files\1cv8\conf\logcfg.xml");
				}
			
		}
	}
}