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
    public partial class StudentT : Form
    {
        public StudentT()
        {
            InitializeComponent();
        }

        private void StudentT_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }


        public void UpdateTable()
        {
            List<Student> student = new List<Student>();
            student = WorkDB.GetStudents();
            DataTable table = new DataTable();
            DataColumn dataColumn = table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nimi", typeof(string));
            table.Columns.Add("Isikukood", typeof(string));
            table.Columns.Add("Kool", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("Ruhm", typeof(string));

            table.PrimaryKey = new DataColumn[] { dataColumn };
            foreach (Student s in student)
            {
                table.Rows.Add(new object[] { s.ID, s.Nimi, s.Isikukood, s.Kool, s.Telefon, s.Ruhm.NimiRuhm});
            }
            table.AcceptChanges();
            dataGridView1.DataSource = table;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.num = 3;
            del.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.num = 2;
            add.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.num = 2;
            update.Show();
        }
    }
}
