using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A135_RadioButton
{
    public partial class Form1 : Form
    {
        private RadioButton checkRB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rbKorea.Checked)
            {
                result += "국적: 대한민국\n";
            }
            else if (rbChina.Checked)
            {
                result += "국적: 중국\n";
            }
            else if (rbJapen.Checked)
            {
                result += "국적: 일본\n";
            }
            else if (rbOthers.Checked)
            {
                result += "국적:  그 외의 국가\n";
            }

            if (checkRB == rbMale)
            {
                result += "성별: 남성";
            }
            else if (checkRB == rbFemale)
            {
                result += "성별: 여성";
                
            }

            MessageBox.Show(result, "Result");
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            checkRB = rbMale;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkRB = rbFemale;
        }
    }
}
