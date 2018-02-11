using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarLibrary;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataTpOfficeApp
{
    public partial class Form1 : Form
    {
        List<Car> cars = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cars = new List<Car>
            {
                new Minivan("VolksWagen Polo",180,10),
                new Minivan("Hyundai Solaris",180,20),
                new Minivan("Lada Granta",160,10)
            };
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = cars;
        }

        private void bnAddNewEntry_Click(object sender, EventArgs e)
        {
            CarAddDialog dialog=new CarAddDialog();
            dialog.Activate();
            dialog.ShowDialog();
            if (dialog.newEntry == null) return;
            cars = ((IEnumerable<Car>)dataGridCars.DataSource).ToList<Car>();
            cars.Add(dialog.newEntry);
            UpdateGrid();
        }

        private void bnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(cars);
        }

        private void ExportToExcel(List<Car> list)
        {
            Excel.Application application = new Excel.Application();
            application.Workbooks.Add();
            Excel.Worksheet worksheet = application.ActiveSheet;
            worksheet.Cells[1, "A"] = "Petname";
            worksheet.Cells[1,"B"] = "Max speed";
            worksheet.Cells[1, "C"] = "Current speed";
            int raw = 1;
            foreach(Car car in list)
            {
                raw++;
                worksheet.Cells[raw,"A"] = car.PetName;
                worksheet.Cells[raw,"B"] = car.MaxSpeed;
                worksheet.Cells[raw,"C"] = car.CurrentSpeed;
            }
            worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);
            worksheet.SaveAs(@"C:\Users\ilya_\Desktop\test.xlsx");
            application.Quit();
        }
    }
}
