
using System;
using System.IO;

namespace RemoveOldBackUpFiles
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] directoryArray=fillDrectoryArray();
			foreach (string directoryPath in directoryArray)
				DeleteBackupFiles(directoryPath);
		}
		static string[] fillDrectoryArray(){
			string[] pathes=new string[4];
			pathes[0]=@"X:\Backup\bp_promservis";
			pathes[1]=@"X:\Backup\buh_promservis";
			pathes[2]=@"X:\Backup\hrm_promservis";
			pathes[3]=@"X:\Backup\it_promservis";
			return pathes;
		}
		static void DeleteBackupFiles(string directorypath)
		{
			if(!Directory.Exists(directorypath)) return;
				string[] files=Directory.GetFiles(directorypath,"*.bak");
				if(files.Length<5) return;
				DateTime[] drArray=new DateTime[files.Length];
				for(int i=0;i<files.Length;i++)
					drArray[i]=File.GetCreationTime(files[i]);
				
				Array.Sort(drArray,files);
				
				for(int i=0;i<files.Length-4;i++)
					File.Delete(files[i]);
				
		}
	
	}
	
	
}