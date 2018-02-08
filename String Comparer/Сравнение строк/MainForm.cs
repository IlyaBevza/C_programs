
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Сравнение_строк
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
		//Очистить от предыдущего результата
		void TB_Begin_1_TextChanged(object sender, EventArgs e)
		{
			TB_END_1.Text=ConvertToInt(TB_Begin_1.Text);
			SetLabelText();
		}
		//Очистить от предыдущего результата
		void TB_Begin_2_TextChanged(object sender, EventArgs e)
		{
			TB_END_2.Text=ConvertToInt(TB_Begin_2.Text);
			SetLabelText();
		}
		
		string  ConvertToInt(string str){
			if(str.Length==0) return string.Empty;
			string temp=string.Empty;
			int num=1;
			foreach(char ch in str)
			{temp+=(int)(ch);
				if(num++!=str.Length)
					temp+=',';
			}
			return temp;
		}
		void SetLabelText(){
			label5.Text="Строки "+(TB_Begin_1.Text==TB_Begin_2.Text ? "равны":"различаются");
		}
	}
}
