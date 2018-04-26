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
            UpdateForm();

        }
        private void UpdateForm()
        {
            List<Ruhm> ruhm = new List<Ruhm>();
            ruhm = WorkDB.GetRuhms();
            DataTable table = new DataTable();
            DataColumn dataColumn = table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nimi", typeof(string));
            table.PrimaryKey = new DataColumn[] { dataColumn };
            foreach (Ruhm r in ruhm)
            {
                table.Rows.Add(new object[] { r.ID, r.NimiRuhm });
            }
            table.AcceptChanges();
            dataGridView1.DataSource = table;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.num = 1;
            del.Show();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.num = 1;
            add.Show();
           
        }

        private void RuhmT_Activated(object sender, EventArgs e)
        {
            UpdateForm();
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }
}
