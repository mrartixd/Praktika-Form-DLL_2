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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        public int num = 0;
        private void Add_Load(object sender, EventArgs e)
        {
            List<Ruhm> ruhms = new List<Ruhm>();
            ruhms = WorkDB.GetRuhms();
            foreach (Ruhm r in ruhms)
            {
                comboBox2.Items.Add(new ComboBoxItem(r.NimiRuhm, Convert.ToString(r.ID)));
            }
            if (num == 1)
            {
                label1.Text = "Nimi rühm";
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            else if (num == 2)
            {
                label1.Text = "Nimi";
                label2.Text = "Isikukood";
                label3.Text = "Kool";
                label4.Text = "Klass";
                label5.Text = "Telefon";
                label6.Text = "Aadress";
                label7.Text = "Ruhm";
                
            }
            else
            {
                label1.Text = "Nimi";
                label2.Text = "Isikukood";
                label5.Text = "Telefon";
                label6.Text = "Aadress";
                label7.Text = "Ruhm";
                label3.Visible = false;
                textBox4.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                textBox4.Visible = false;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox7.Clear();
            textBox6.Clear();
        }

        private void Add_Leave(object sender, EventArgs e)
        {
            if(num == 1)
            {
                RuhmT ruhmT = new RuhmT();

                num = 0;
            }

            num = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(num ==1)
            {
                Ruhm ruhm = new Ruhm();
                ruhm.NimiRuhm = textBox1.Text;

                int arv = WorkDB.InsertNewRuhm(ruhm);
                if(arv !=0)
                {
                    MessageBox.Show("Oli lisatud " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RuhmT ruhmt = new RuhmT();
                    ruhmt.Refresh();                    
                    this.Close();
                }
                else
                { MessageBox.Show("Lisamine ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else if(num == 2)
            {
                Student student = new Student();
                student.Nimi = textBox1.Text;
                student.Isikukood = Convert.ToInt32(textBox3.Text);
                student.Kool = textBox4.Text;
                student.Klass = Convert.ToInt32(comboBox1.SelectedItem);
                student.Telefon = textBox6.Text;
                student.Aadress = textBox7.Text;
                student.Ruhm = Convert.ToInt32(((ComboBoxItem)comboBox2.SelectedItem).HiddenValue);
                int arv = WorkDB.InsertNewStudent(student);
                if (arv!=0)
                {
                    MessageBox.Show("Oli lisatud " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentT studentT = new StudentT();
                    studentT.Refresh();
                    this.Close();
                }
                else
                { MessageBox.Show("Lisamine ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                Teacher teacher = new Teacher();
                teacher.Nimi = textBox1.Text;
                teacher.Isikukood = Convert.ToInt32(textBox3.Text);
                teacher.Telefon = textBox6.Text;
                teacher.Aadress = textBox7.Text;
                teacher.Ruhm = Convert.ToInt32(((ComboBoxItem)comboBox2.SelectedItem).HiddenValue);
                int arv = WorkDB.InsertNewTeacher(teacher);
                if (arv != 0)
                {
                    MessageBox.Show("Oli lisatud " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeacherT teacherT = new TeacherT();
                    teacherT.Refresh();
                    this.Close();
                }
                else
                { MessageBox.Show("Lisamine ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
