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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textboxname.Clear();
            textBoxid.Clear();
            textBoxKool.Clear();
            comboBox1.SelectedIndex = -1;
            comboBoxKlass.SelectedIndex = -1;
            textBoxTel.Clear();
            textBoxAdr.Clear();
            checkBox1.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Student student = new Student();
                student.Nimi = textboxname.Text;
                student.Isikukood = Convert.ToInt32(textBoxid.Text);
                student.Kool = textBoxKool.Text;
                student.Klass = Convert.ToInt32(comboBoxKlass.SelectedValue);
                student.Aadress = textBoxAdr.Text;
                student.Telefon = textBoxTel.Text;
                student.Ruhm = Convert.ToInt32(((ComboBoxItem)comboBox1.SelectedItem).HiddenValue);
                int arv = WorkDB.InsertNewStudent(student);
                if (arv != 0)
                {
                    MessageBox.Show("Oli lisatud " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { MessageBox.Show("Lisamine ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }else
            { MessageBox.Show("Check checkbox", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Ruhm> ruhms = new List<Ruhm>();
            ruhms = WorkDB.GetRuhms();
            foreach (Ruhm r in ruhms)
            {
                comboBox1.Items.Add(new ComboBoxItem(r.NimiRuhm, Convert.ToString(r.ID)));
            }
        }
    }
}
