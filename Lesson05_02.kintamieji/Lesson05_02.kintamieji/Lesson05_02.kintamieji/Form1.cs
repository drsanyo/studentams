using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson05_02.kintamieji
{
    public partial class Form1 : Form
    {
        public int[] biologiniaiParametrai = new int[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPadetiIMasyva_Click(object sender, EventArgs e)
        {
            biologiniaiParametrai[0] = int.Parse(tbUgis.Text);
            biologiniaiParametrai[1] = int.Parse(tbSvoris.Text);
        }

        private void BtnParodytiMasyva_Click(object sender, EventArgs e)
        {
            tbOutput.Clear();
            foreach (var parametras in biologiniaiParametrai)
            {
                string eilute = string.Format("Pirmas masyvo elementas yra: {0}{1}", 
                    parametras, Environment.NewLine);
                tbOutput.AppendText(eilute);
            }
        }
    }
}
