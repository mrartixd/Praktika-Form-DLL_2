using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL2
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "admin" || textBoxPass.Text == "admin")
            {
                this.Close();
                AdminP adminpanel = new AdminP();
                adminpanel.Show();
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Login fail";
            }
        }
    }
}
