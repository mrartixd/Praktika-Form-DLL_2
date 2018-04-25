﻿using System;
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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        public int num = 0;

        private void Delete_Load(object sender, EventArgs e)
        {
            if(num == 1)
            {
                List<Ruhm> list = new List<Ruhm>();
                list = WorkDB.GetRuhms();
                foreach (Ruhm r in list)
                {
                    comboBox1.Items.Add(new ComboBoxItem(r.NimiRuhm, Convert.ToString(r.ID)));
                }
            }else if(num == 2)
            {
                List<Teacher> list = new List<Teacher>();
                list = WorkDB.GetTeachers();
                foreach (Teacher t in list)
                {
                    comboBox1.Items.Add(new ComboBoxItem(Convert.ToString(t.Isikukood), Convert.ToString(t.ID)));
                }
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                int arv = WorkDB.DeleteRuhm(Convert.ToInt32(((ComboBoxItem)comboBox1.SelectedItem).HiddenValue));
                if (arv != 0)
                {
                    MessageBox.Show("Oli delete " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                { MessageBox.Show("Delete ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }else if(num == 2)
            {
                int arv = WorkDB.DeleteTeacher(Convert.ToInt32(((ComboBoxItem)comboBox1.SelectedItem).HiddenValue));
                if (arv != 0)
                {
                    MessageBox.Show("Oli delete " + arv + " rida", "Valmis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                { MessageBox.Show("Delete ebaõnnestus", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            
        }

        private void Delete_Leave(object sender, EventArgs e)
        {
            num = 0;
        }
    }
}