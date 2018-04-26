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
    public partial class AdminP : Form
    {
        public AdminP()
        {
            InitializeComponent();
        }

        private void rühmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuhmT ruhmform = new RuhmT();
            ruhmform.MdiParent = this;
            ruhmform.Show();
        }

        private void tudengToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentT student = new StudentT();
            student.MdiParent = this;
            student.Show();
        }

        private void õpetajadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherT teachert = new TeacherT();
            teachert.MdiParent = this;
            teachert.Show();
        }

        private void AdminP_Activated(object sender, EventArgs e)
        {
            RuhmT ruhmform = new RuhmT();
            ruhmform.Refresh();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
