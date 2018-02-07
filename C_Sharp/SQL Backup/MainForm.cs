
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Backup
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			SetInitialProperties();
		}
		
		private void SetInitialProperties(){
			
			BaseName.Text=BaseName.Items[0].ToString();
			tbLogin.Text="sa";
			
			setBackupDestinationPath();
			
		}
		private void setBackupDestinationPath(){
			tbBackupDestination.Text=@"X:\Backup\"+BaseName.Text;
			
		}
		
		private string createConnectionString(){
			SqlConnectionStringBuilder builder=new SqlConnectionStringBuilder();
			builder.DataSource="SRV-MSSQL01";
			builder.InitialCatalog=BaseName.Text;
			builder.UserID=tbLogin.Text;
			builder.Password=tbPassword.Text;
			return builder.ConnectionString;
			
		}
		
		//Event handlers
		void BaseName_TextUpdate(object sender, EventArgs e)
		{
			setBackupDestinationPath();
			
		}
		
		void BaseName_SelectedIndexChanged(object sender, EventArgs e)
		{
			setBackupDestinationPath();
			
		}
		
		
		
		void BCheckConnection_Click(object sender, EventArgs e)
		{
			string connectionString=createConnectionString();
			using (SqlConnection connection = new SqlConnection(connectionString))
			    {
			        connection.Open();
			       MessageBox.Show("Подключение открыто");
			    }
			     MessageBox.Show("Подключение закрыто...");
			 
		}
	}
}
