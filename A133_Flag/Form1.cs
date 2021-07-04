using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A133_Flag
{
    public partial class Form1 : Form
    {
        private bool flags; //디폴트는 false

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flags == false)
            {
                label1.Text = "Hello Wolrd!";
                flags = true;
            }
            else 
            {
                label1.Text = "";
                flags = false;
            }
        }
    }
}
