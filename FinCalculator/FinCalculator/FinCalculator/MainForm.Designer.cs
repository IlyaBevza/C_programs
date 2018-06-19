/*
 * Дата: 29.05.2018
 * Время: 4:43
 */
namespace FinCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView MainTable;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainTable = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTable
			// 
			this.MainTable.AllowUserToOrderColumns = true;
			this.MainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainTable.Location = new System.Drawing.Point(12, 54);
			this.MainTable.Name = "MainTable";
			this.MainTable.Size = new System.Drawing.Size(776, 312);
			this.MainTable.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 497);
			this.Controls.Add(this.MainTable);
			this.Name = "MainForm";
			this.Text = "Финансовый калькулятор";
			((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
