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
    }
}
