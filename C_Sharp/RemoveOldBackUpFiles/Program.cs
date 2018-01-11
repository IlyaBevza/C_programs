
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
			pathes[0]=@"E:\Backup\bp_promservis";
			pathes[1]=@"E:\Backup\buh_promservis";
			pathes[2]=@"E:\Backup\hrm_promservis";
			pathes[3]=@"E:\Backup\it_promservis";
			return pathes;
		}
		static void DeleteBackupFiles(string directorypath)
		{
			if(!Directory.Exists(directorypath)) return;
				string[] files=Directory.GetFiles(directorypath,"*.bak");
				if(files.Length<2) return;
				DateTime[] drArray=new DateTime[files.Length];
				for(int i=0;i<files.Length;i++)
					drArray[i]=File.GetCreationTime(files[i]);
				
				Array.Sort(drArray,files);
				
				for(int i=0;i<files.Length-2;i++)
					File.Delete(files[i]);
			
		}
	
	}
	
	
}