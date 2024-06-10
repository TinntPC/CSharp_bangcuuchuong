using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            lbsKetqua.Items.Clear();
            int cc = Convert.ToInt32(txtSo.Text);
            for (int i = 1; i <= 10; i++)
            {
                lbsKetqua.Items.Add(txtSo.Text + " x " + i.ToString() + " = " + Convert.ToString(cc*i));
            }
        }
    }
}
