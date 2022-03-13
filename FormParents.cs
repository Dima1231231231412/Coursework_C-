using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class FormParents : Form
    {
        DatabaseMain dbm;

        public FormParents(DatabaseMain _dbm)
        {
            InitializeComponent();
            dbm = _dbm;
            dataGridViewParents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewParents.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewParents.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            comboBox1.Items.AddRange(new string[] { "По ФИО родителя", "По номеру телефона" });
            comboBox2.Items.AddRange(new string[] { "По ФИО родителя", "По номеру телефона" });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {    
            Parents p = new Parents();
            FormParentsEdit fpe = new FormParentsEdit(p, dbm);
            fpe.ShowDialog();
            if (fpe.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bindingSourceParents.Add(p);
                dbm.SubmitChanges();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Parents p;
            if (bindingSourceParents.Current != null)
            {
                p = (Parents)bindingSourceParents.Current;
                FormParentsEdit fpe = new FormParentsEdit(p, dbm);
                fpe.ShowDialog();
                if (fpe.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bindingSourceParents.ResetCurrentItem();
                    dbm.SubmitChanges();
                }
            }
        }

        private void FormParents_Load(object sender, EventArgs e)
        {
            bindingSourceParents.DataSource = dbm.Parents;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Parents p;
            if (bindingSourceParents.Current != null)
            {
                p = (Parents)bindingSourceParents.Current;
                DialogResult dr = MessageBox.Show($"Удалить родителя c ФИО '{ p.FioParents}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    bindingSourceParents.Remove(p);
                    dbm.SubmitChanges();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            IQueryable<Parents> iqp = dbm.Parents;
            if (checkBoxByFio.Checked)
            {
                iqp = iqp.Where(x => x.FioParents.Contains(textBoxSearchFio.Text));
            }
            if (checkBoxByPhoneNumber.Checked)
            {
                int phone;
                if (Int32.TryParse(textBoxSearchPhoneNumber.Text, out phone))
                    iqp = iqp.Where(x => x.ParentsPhoneNumber.Contains(phone.ToString()));
            }
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.FioParents);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.ParentsPhoneNumber);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.FioParents).ThenBy(x => x.ParentsPhoneNumber);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.ParentsPhoneNumber).ThenBy(x => x.FioParents);
            }    
            bindingSourceParents.DataSource = iqp;     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                comboBox1.Visible = true;
            comboBox2.Visible = false;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedItem = -1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
            }
        }

        private void checkBoxByFio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByFio.Checked)
                textBoxSearchFio.ReadOnly = false;
            else
                textBoxSearchFio.ReadOnly = true;
        }

        private void checkBoxByPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByPhoneNumber.Checked)
                textBoxSearchPhoneNumber.ReadOnly = false;
            else
                textBoxSearchPhoneNumber.ReadOnly = true;
        }

    }
}


