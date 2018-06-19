/*
 * Дата: 29.05.2018
 * Время: 4:43
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinCalculator
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
			AddDefaultRows();
			
		}
		private void AddDefaultRows(){
			System.Data.DataTable table=new System.Data.DataTable("Table");
			AddColumn(ref table,"System.String","Operation","Операция");
			AddColumn(ref table,"System.Double","PresentValue","Приведенная стоимость");
			AddColumn(ref table,"System.Double","Interest","Ставка");
			AddColumn(ref table,"System.Double","Duration","Срок");
			AddColumn(ref table,"System.Double","FutureValue","Будущая стоимость");
			MainTable.DataSource=table;
		}
		private void AddColumn(ref System.Data.DataTable table,string columntype,string name,string caption){
			System.Data.DataColumn column;
			column=new System.Data.DataColumn();
			column.DataType=Type.GetType(columntype);
			column.ColumnName=name;
			column.Caption=caption;
			table.Columns.Add(column);
		}
		
		
		
	}
	
}
