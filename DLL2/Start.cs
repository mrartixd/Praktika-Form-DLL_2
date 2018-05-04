using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lastelaagridb;

namespace DLL2
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabel tabel = new Tabel();
            tabel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminP adminpanel = new AdminP();
                adminpanel.Show();
                textBox2.Text = "";
                label4.Visible = false;


            }
            else
            {
                label4.Visible = true;
                label4.Text = "Login fail";
            }
        }
    }
}
