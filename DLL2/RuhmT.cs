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
    public partial class RuhmT : Form
    {
        public RuhmT()
        {
            InitializeComponent();
        }

        private void RuhmT_Load(object sender, EventArgs e)
        {
            List<Ruhm> ruhm = new List<Ruhm>();
            ruhm = WorkDB.GetRuhms();

            
            


            foreach (Ruhm r in ruhm)
            {
               
            }
            

            
        }
    }
}
