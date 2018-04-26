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
    public partial class TeacherT : Form
    {
        public TeacherT()
        {
            InitializeComponent();
        }

        private void TeacherT_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            List<Teacher> teacher = new List<Teacher>();
            teacher = WorkDB.GetTeachers();
            DataTable table = new DataTable();
            DataColumn dataColumn = table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nimi", typeof(string));
            table.Columns.Add("Isikukood", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Ruhm", typeof(string));

            table.PrimaryKey = new DataColumn[] { dataColumn };
            foreach (Teacher t in teacher)
            {
                table.Rows.Add(new object[] { t.ID, t.Nimi, t.Isikukood, t.Telefon, t.Ruhm });
            }
            table.AcceptChanges();
            dataGridView1.DataSource = table;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.num = 3;
            add.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.num = 3;
            update.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.num = 2;
            del.Show();
        }
    }
}
