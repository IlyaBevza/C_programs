
namespace Сравнение_строк
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.TB_Begin_1 = new System.Windows.Forms.TextBox();
			this.TB_Begin_2 = new System.Windows.Forms.TextBox();
			this.TB_END_2 = new System.Windows.Forms.TextBox();
			this.TB_END_1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TB_Begin_1
			// 
			this.TB_Begin_1.Location = new System.Drawing.Point(24, 48);
			this.TB_Begin_1.Name = "TB_Begin_1";
			this.TB_Begin_1.Size = new System.Drawing.Size(328, 20);
			this.TB_Begin_1.TabIndex = 0;
			this.TB_Begin_1.TextChanged += new System.EventHandler(this.TB_Begin_1_TextChanged);
			// 
			// TB_Begin_2
			// 
			this.TB_Begin_2.Location = new System.Drawing.Point(24, 88);
			this.TB_Begin_2.Name = "TB_Begin_2";
			this.TB_Begin_2.Size = new System.Drawing.Size(328, 20);
			this.TB_Begin_2.TabIndex = 1;
			this.TB_Begin_2.TextChanged += new System.EventHandler(this.TB_Begin_2_TextChanged);
			// 
			// TB_END_2
			// 
			this.TB_END_2.Location = new System.Drawing.Point(384, 88);
			this.TB_END_2.Name = "TB_END_2";
			this.TB_END_2.ReadOnly = true;
			this.TB_END_2.Size = new System.Drawing.Size(328, 20);
			this.TB_END_2.TabIndex = 3;
			// 
			// TB_END_1
			// 
			this.TB_END_1.Location = new System.Drawing.Point(384, 48);
			this.TB_END_1.Name = "TB_END_1";
			this.TB_END_1.ReadOnly = true;
			this.TB_END_1.Size = new System.Drawing.Size(328, 20);
			this.TB_END_1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(360, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "(";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(360, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "(";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(720, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = ")";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(720, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = ")";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(24, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(688, 24);
			this.label5.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(64, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(256, 16);
			this.label6.TabIndex = 9;
			this.label6.Text = "Сравниваем";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(136, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "С";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(416, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(256, 16);
			this.label8.TabIndex = 11;
			this.label8.Text = "Получаем";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 161);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TB_END_2);
			this.Controls.Add(this.TB_END_1);
			this.Controls.Add(this.TB_Begin_2);
			this.Controls.Add(this.TB_Begin_1);
			this.Name = "MainForm";
			this.Text = "Сравнение строк";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_END_1;
		private System.Windows.Forms.TextBox TB_END_2;
		private System.Windows.Forms.TextBox TB_Begin_2;
		private System.Windows.Forms.TextBox TB_Begin_1;
	}
}
