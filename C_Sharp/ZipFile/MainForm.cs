
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ARC=System.IO.Compression;

namespace ZipFile
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BnSelectFile_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog=new FolderBrowserDialog();
			if(dialog.ShowDialog()==DialogResult.OK)
			{
				tbTarget.Text=dialog.SelectedPath;
				tbDestination.Text=tbTarget.Text+"\\log.zip";
			}
		}
		
		void BnZip_Click(object sender, EventArgs e)
		{
			try{
				ARC.ZipFile.CreateFromDirectory(tbTarget.Text,tbDestination.Text);
				}
			catch(Exception ex)
			{
				Console.WriteLine("{0",ex.Message);
			}
			
		}
		
		void BnSelectdestination_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog=new FolderBrowserDialog();
			if(dialog.ShowDialog()== DialogResult.OK)
				tbDestination.Text=dialog.SelectedPath+"\\log.zip";
		}
		
		void TbTarget_TextChanged(object sender, EventArgs e)
		{
						
		}
	}
}
