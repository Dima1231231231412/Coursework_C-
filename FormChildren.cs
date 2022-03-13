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

    public partial class FormChildren : Form
    {
        DatabaseMain dbm;
        public FormChildren(DatabaseMain _dbm)
        {
            InitializeComponent();
            dbm = _dbm;
            dataGridViewChildren.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewChildren.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewChildren.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            comboBox1.Items.AddRange(new string[] { "По дате рождения", "По группе" });
            comboBox2.Items.AddRange(new string[] { "По дате рождения", "По группе" });
        }

        private void FormChildren_Load(object sender, EventArgs e)
        {
            bindingSourceChildren.DataSource = dbm.Children;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Children c = new Children()
            {
                DateOfBirth = new DateTime(2000, 1, 1)
            };
            FormChildrenEdit fce = new FormChildrenEdit(c, dbm);
            fce.ShowDialog();
            if (fce.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bindingSourceChildren.Add(c);
                dbm.SubmitChanges();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Children c;
            if (bindingSourceChildren.Current != null)
            {
                c = (Children)bindingSourceChildren.Current;
                FormChildrenEdit fce = new FormChildrenEdit(c, dbm);
                fce.ShowDialog();
                if (fce.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bindingSourceChildren.ResetCurrentItem();
                    dbm.SubmitChanges();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Children c;
            if (bindingSourceChildren.Current != null)
            {
                c = (Children)bindingSourceChildren.Current;
                if (c.Parents.Count() != 0)
                {
                    MessageBox.Show("Удаление записи невозможно, так как имеется связь с таблицей 'Родители'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Удалить ребёнка с ФИО '{c.FioChildren}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        bindingSourceChildren.Remove(c);
                        dbm.SubmitChanges();
                    }
                }
            }
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

        private void checkBoxByFioChildren_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByFioChildren.Checked)
                textBoxSearchFioChildren.ReadOnly = false;
            else
                textBoxSearchFioChildren.ReadOnly = true;
        }

        private void checkBoxByPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByPhoneNumber.Checked)
                textBoxSearchPhoneNumber.ReadOnly = false;
            else
                textBoxSearchPhoneNumber.ReadOnly = true;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            IQueryable<Children> iqp = dbm.Children;
            if (checkBoxByFioChildren.Checked)
            {
                iqp = iqp.Where(x => x.FioChildren.Contains(textBoxSearchFioChildren.Text));
            }
            if (checkBoxByPhoneNumber.Checked)
            {
                int phone;
                if (Int32.TryParse(textBoxSearchPhoneNumber.Text, out phone))
                    iqp = iqp.Where(x => x.ChildsPhoneNumber.Contains(phone.ToString()));
            }
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderByDescending(x => x.DateOfBirth);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.Groups.Name);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderByDescending(x => x.DateOfBirth).ThenBy(x => x.Groups.Name);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.Groups.Name).ThenByDescending(x => x.DateOfBirth);
            }
            bindingSourceChildren.DataSource = iqp;
        }

    }
}
