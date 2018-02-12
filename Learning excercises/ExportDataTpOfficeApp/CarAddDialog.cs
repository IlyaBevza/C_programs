using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using CarLibrary;

namespace ExportDataTpOfficeApp
{
    public partial class CarAddDialog : Form
    {
        public Car newEntry { get; set; }
        public CarAddDialog()
        {
            InitializeComponent();
            tbCurrentSpeed.Text = "5";
            tbMaxSpeed.Text = "150";
            newEntry = null;
        }

        private void CarAddDialog_Load(object sender, EventArgs e)
        {
            LoadCarTypes();
        }
        private void LoadCarTypes()
        {
            cbCarType.DataSource = null;
            List<string> list = new List<string>();
            var cars= from car in Assembly.Load("CarLibrary").GetTypes()
                      where car.IsClass && !car.IsAbstract select car.Name;
            foreach (var car in cars)
                list.Add(car);
            cbCarType.DataSource = list;
        }

        private void bmAddCar_Click(object sender, EventArgs e)
        {
            if (cbCarType.Text == string.Empty || tbCarName.Text == string.Empty
                || tbCurrentSpeed.Text == string.Empty || tbMaxSpeed.Text == string.Empty)
            {
                MessageBox.Show("Not all fields are filled");
                return;
            }
            var types =  from classes in Assembly.Load("CarLibrary").GetTypes()  where classes.IsClass select classes;
            foreach(var type in types)
            {
                if (type == null) break;
                if (type.Name != cbCarType.Text) continue;
                object[] pars = new object[] { tbCarName.Text, Int32.Parse(tbMaxSpeed.Text), Int32.Parse(tbCurrentSpeed.Text) };
                newEntry = (Car)Activator.CreateInstance(type,pars);
                
            }
            Close();
        }
    }
}
