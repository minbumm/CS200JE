using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A126_FormWithConsole
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            CreateMyForm();
        }
        private static void CreateMyForm()
        {
            Form form1 = new Form();

            Button button1 = new Button();
            Button button2 = new Button();


            button1.Text = "OK";
            button1.Location = new Point(10, 10);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);

            form1.Text = "My Dialog Box";
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok Button Clicked!");
        }
    }
}
