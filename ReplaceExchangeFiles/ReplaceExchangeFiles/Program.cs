
using System;
using System.IO;

namespace ReplaceExchangeFiles
{
	class Program
	{
		const string destinationDirectory=@"C:\Exchange";
		public static void Main(string[] args)
		{
			if(args.Length==0) GetHelp();
			else {
				SetAction(args);
			}	
		}		
		private static void ReplaceXMLFiles(string path){
			
			DirectoryInfo FromDir=new DirectoryInfo(@path);
			if (!FromDir.Exists) return;
			
			DirectoryInfo DestinationDir=new DirectoryInfo(destinationDirectory);
			if(!DestinationDir.Exists)
			try
				{DestinationDir.Create();}
			catch(Exception)
				{return;}
			foreach(FileInfo file in FromDir.GetFiles("*.xml"))
			{	string name=@DestinationDir+"\\"+file.Name;
				file.MoveTo(name);				
			}			
		}
		private static void RenameUsedFiles(){
			DirectoryInfo dir=new DirectoryInfo(destinationDirectory);
			if(!dir.Exists) return;
			
			foreach(FileInfo file in dir.GetFiles("*.xml"))
			        file.MoveTo(file.FullName.Replace("xml","bak"));
			
		}
		private static void DeleteFiles(){
			DirectoryInfo dir=new DirectoryInfo(destinationDirectory);
			if(!dir.Exists) return;
			foreach(FileInfo file in dir.GetFiles("*.bak"))
			        file.Delete();
			
		}
		private static void GetHelp(){
			Console.WriteLine("Данная программа выполняется только со следующими параметрами командной строки:");
			Console.WriteLine("-rep: Далее через пробел в кавычках путь, откуда будут перемещаться xml-файлы для обмена.");
			Console.WriteLine("-bak: Изменить расширение файлов выгрузки на .bak");
			Console.WriteLine("-del: Удалить файлы с расширением bak");
			Console.Write("Нажмите любую кнопку, чтобы закрыть программу...");
			Console.ReadKey(true);
		}
		private static void SetAction(string[] args){
			switch(args[0]){
				case "-rep":
					if(args.Length<2)GetHelp();
					else ReplaceXMLFiles(args[1]);
					break;
				case "-del":
					DeleteFiles();
					break;
				case "-bak":
					RenameUsedFiles();
					break;
				default:GetHelp();
					break;
			}
			
			
		}
	}
}