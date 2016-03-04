using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush01_Click(object sender, EventArgs e)
        {
            int x;
            int total;

            x = Convert.ToInt32(txtBox02.Text);
            total = 2016 - x;

            lblBox01.Text = txtBox01.Text + " is " + total + " years old.";
        }
    }
}
