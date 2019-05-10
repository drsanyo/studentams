using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson05_03.listBox
{
    public partial class frmPazymiai : Form
    {
        private List<int> pazymiai = new List<int>();
        public frmPazymiai()
        {
            InitializeComponent();
        }

        private void BtnPrideti_Click(object sender, EventArgs e)
        {
            pazymiai.Add(int.Parse(tbPazymis.Text));
            tbPazymis.Text = "";

            lbxPazymiai.Items.Clear();
            foreach (int pazymis in pazymiai)
            {
                lbxPazymiai.Items.Add(pazymis);
            }
        }

        private void BtnIštrinti_Click(object sender, EventArgs e)
        {
            //pazymiai.Add(int.Parse(tbPazymis.Text));

            int pazymetaEilute = lbxPazymiai.SelectedIndex;
            if (pazymetaEilute != -1)
            {
                pazymiai.RemoveAt(pazymetaEilute);
            }

            lbxPazymiai.Items.Clear();
            foreach (int pazymis in pazymiai)
            {
                lbxPazymiai.Items.Add(pazymis);
            }
        }
    }
}
