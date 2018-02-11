using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CommonSnappableTypes;

namespace MyExtendableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileItemSnapInModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName.Contains("CommonSnappableTypes"))
                    MessageBox.Show("CommonSnappableTypes has no snap-ins");
                else if (!LoadExternalModule(dialog.FileName))
                    MessageBox.Show("Nothing implements IAppfunctionality");
            }
        }
        private bool LoadExternalModule(string filename)
        {
            bool FoundSnapIn = false;
            Assembly theSnapIn = null;
            try
            {
                theSnapIn = Assembly.LoadFrom(filename);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return FoundSnapIn;
            }
            var theClassTypes = from c in theSnapIn.GetTypes()
                                where c.IsClass && (c.GetInterface("IPublicFuncionality")!=null) select c;
            foreach(Type type in theClassTypes)
            {
                FoundSnapIn = true;
                IPublicFuncionality instance = (IPublicFuncionality)theSnapIn.CreateInstance(type.FullName, true);
                instance.DoIt();
                listLoadedSnapIns.Items.Add(type.FullName);
            }
            return FoundSnapIn;
        }
    }
}
