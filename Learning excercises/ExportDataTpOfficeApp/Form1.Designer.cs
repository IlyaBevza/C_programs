namespace ExportDataTpOfficeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.bnAddNewEntry = new System.Windows.Forms.Button();
            this.bnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(12, 12);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(518, 210);
            this.dataGridCars.TabIndex = 0;
            // 
            // bnAddNewEntry
            // 
            this.bnAddNewEntry.Location = new System.Drawing.Point(12, 233);
            this.bnAddNewEntry.Name = "bnAddNewEntry";
            this.bnAddNewEntry.Size = new System.Drawing.Size(187, 29);
            this.bnAddNewEntry.TabIndex = 1;
            this.bnAddNewEntry.Text = "Add new entry";
            this.bnAddNewEntry.UseVisualStyleBackColor = true;
            this.bnAddNewEntry.Click += new System.EventHandler(this.bnAddNewEntry_Click);
            // 
            // bnExportToExcel
            // 
            this.bnExportToExcel.Location = new System.Drawing.Point(350, 233);
            this.bnExportToExcel.Name = "bnExportToExcel";
            this.bnExportToExcel.Size = new System.Drawing.Size(180, 29);
            this.bnExportToExcel.TabIndex = 2;
            this.bnExportToExcel.Text = "Eport to Excel";
            this.bnExportToExcel.UseVisualStyleBackColor = true;
            this.bnExportToExcel.Click += new System.EventHandler(this.bnExportToExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 269);
            this.Controls.Add(this.bnExportToExcel);
            this.Controls.Add(this.bnAddNewEntry);
            this.Controls.Add(this.dataGridCars);
            this.Name = "Form1";
            this.Text = "Export to Office";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.Button bnAddNewEntry;
        private System.Windows.Forms.Button bnExportToExcel;
    }
}

