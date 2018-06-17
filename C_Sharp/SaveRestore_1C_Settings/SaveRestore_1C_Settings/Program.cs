using System;
using System.Configuration;
using System.IO;

namespace SaveRestore_1C_Settings
{
	class Program
	{
		public static void Main(string[] args)
		{
			AppSettingsReader sreader=new AppSettingsReader();
			string MainPosition=  (string)sreader.GetValue("MainPosition",typeof(string));
			string BackupPosition=(string)sreader.GetValue("BackupPosition",typeof(string));
			if(MainPosition==null || BackupPosition==null){
				throw new Exception("Не найдены настройки программы");
			}
			DirectoryInfo mainDirectory=new DirectoryInfo(MainPosition);
			
			if(!mainDirectory.Exists){
				throw new Exception("Не найдена папка настроек пользователей");
			}
			DirectoryInfo backupDirectory=new DirectoryInfo(BackupPosition);
			if(!backupDirectory.Exists){
				throw new Exception("Не найдена папка бэкапа настроек пользователей");
			}
			
			//Копирование настроек
			CopyFiles(mainDirectory,backupDirectory);
			//Восстановление настроек
			CopyFiles(backupDirectory,mainDirectory);

		}
		
		// Перемещаются  только отсутствующие в месте назначения или большего размера файлы
		static void CopyFiles(DirectoryInfo From,DirectoryInfo To){
			FileInfo[] files=From.GetFiles("*.pfl");
			if(files.Length==0){
				throw new Exception("Не найдено ни одного файла pfl");
			}
			foreach(FileInfo file in files){
				FileInfo substitutedFile=new FileInfo(To.FullName+"\\"+file.Name);
				if(!substitutedFile.Exists || file.Length>substitutedFile.Length){
					try{
						file.CopyTo(substitutedFile.FullName,true);
					}
					catch{
						continue;
					}
				}
				                                      			
			}
		}
	}
}
