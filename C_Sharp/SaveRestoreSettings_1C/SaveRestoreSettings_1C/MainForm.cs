/*
 * Дата: 13.05.2018
 * Время: 20:17
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace SaveRestoreSettings_1C
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string applicationPath,baseGUID,baseSettingsPath,backupPath;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			InitializePaths();
			
		}
		void InitializePaths(){
			applicationPath=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+@"\1C\1Cv8";
			baseSettingsPath=baseGUID=backupPath=string.Empty;
			backupPath=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Backup_1С";
		}
		void SaveSettingsClick(object sender, EventArgs e)
		{
			if(!JobIsPossible()) return;
			DialogResult dialog=MessageBox.Show("Сохранить настройки?","",MessageBoxButtons.OKCancel);
			if(dialog==DialogResult.Cancel)
				return;
			baseSettingsPath=applicationPath+@"\"+baseGUID;
				
			CopyDir(baseSettingsPath,backupPath);
			SetBalloonTip("Настройки сохранены");			
		}
		
		private bool JobIsPossible(){
			
			
			if(!Directory.Exists(applicationPath))
			{
				MessageBox.Show("К сожалению, папка настроек не найдена. Сообщите об этом программисту 1С");
				return false;;
			}
			
			string filePath=applicationPath+@"\v8ib.lst";
			if(!File.Exists(filePath))
			{
				MessageBox.Show("Файл списка баз 1С 8.0 не найден. Сообщите об этом программисту 1С");
				return false;
			}
			using (StreamReader reader=File.OpenText(filePath))
			{
				string line=string.Empty;
				
				while(!reader.EndOfStream)
				{
					line=reader.ReadLine();
					if(line.Contains("ut_rabochaya"))
					{
						baseGUID=reader.ReadLine().Replace("ID=","");
						break;
					}				
				}
				if(baseGUID==string.Empty)
				{
					MessageBox.Show("Не удалось установить GUID базы");
					return false;
				}
			};
			if(!Directory.Exists(applicationPath+@"\"+baseGUID))
			{
				MessageBox.Show("Не удалось найти папку базы с настройками");
				return false;
			}
			return true;;
		}
		void CopyDir(string FromDir, string ToDir){
			Directory.CreateDirectory(ToDir);
		    foreach (string s1 in Directory.GetFiles(FromDir))
		    {
		        string s2 = ToDir + "\\" + Path.GetFileName(s1);
		        File.Copy(s1,s2,true);
		    }
		    foreach (string s in Directory.GetDirectories(FromDir))
		    {
		        CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
		    }
		}
		void RestoreSettingsClick(object sender, EventArgs e)
		{
			if(!JobIsPossible()) return;
			if(Directory.GetFiles(backupPath).Length==0)
			{
				MessageBox.Show("Не удалось найти сохраненные файлы настроек");
				return;
			}
			DialogResult dialog=MessageBox.Show("Восстановить настройки?","",MessageBoxButtons.OKCancel);
			if(dialog==DialogResult.Cancel)
				return;
			baseSettingsPath=applicationPath+@"\"+baseGUID;
			
				
			CopyDir(backupPath,baseSettingsPath);
			SetBalloonTip("Настройки восстановлены");
			
		}
		private void SetBalloonTip(string text)
			{
			MessageBox.Show(text);
			}
		
		
	}
	

}
