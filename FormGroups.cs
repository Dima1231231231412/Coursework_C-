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
    public partial class FormGroups : Form
    {        
        DatabaseMain dbm;
        public FormGroups(DatabaseMain _dbm)
        {
            InitializeComponent();
            dbm = _dbm;
            dataGridViewGroups.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewGroups.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewGroups.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            comboBox1.Items.AddRange(new string[] { "По макс.кол-во детей", "По стоимости месяца обучения" });
            comboBox2.Items.AddRange(new string[] { "По макс.кол-во детей", "По стоимости месяца обучения" });
        }
        private void FormGroups_Load(object sender, EventArgs e)
        {
          bindingSourceGroups.DataSource = dbm.Groups;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Groups g;
            if (bindingSourceGroups.Current != null)
            {
                g = (Groups)bindingSourceGroups.Current;
                FormGroupsEdit fge = new FormGroupsEdit(g);
                fge.ShowDialog();
                if (fge.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bindingSourceGroups.ResetCurrentItem();
                    dbm.SubmitChanges();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Groups g = new Groups()
            {
                TypeOfActivity = "Аэробика",
                MaxNumberOfChildren = 12,
                MaxAgeInTheGroup = 18,
                MinAgeInTheGroup = 12,
                CostOfaMonthOfTraining = 3500
            };
            FormGroupsEdit fge = new FormGroupsEdit(g);
            fge.ShowDialog();
            if (fge.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bindingSourceGroups.Add(g);
                dbm.SubmitChanges();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Groups g;
            if (bindingSourceGroups.Current != null)
            {
                g = (Groups)bindingSourceGroups.Current;
                if (g.Schedule.Count() != 0)
                {
                    MessageBox.Show("Удаление записи невозможно, так как имеется связь с таблицей 'Расписание'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (g.Children.Count() != 0)
                {
                    MessageBox.Show("Удаление записи невозможно, так как имеется связь с таблицей 'Дети'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Удалить группу '{g.Name}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        bindingSourceGroups.Remove(g);
                        dbm.SubmitChanges();
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void checkBoxByTypeOfActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByTypeOfActivity.Checked)
               textBoxSearchTypeOfActivity.ReadOnly = false;
            else
                textBoxSearchTypeOfActivity.ReadOnly = true;
        }

        private void checkBoxByNumberOfChildren_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByNumberOfChildren.Checked)
            {
                textBoxSearchMinAgeInGroup.ReadOnly = false;
                textBoxSearchMaxAgeInGroup.ReadOnly = false;
            }
            else
            {
                textBoxSearchMaxAgeInGroup.ReadOnly = true;
                textBoxSearchMinAgeInGroup.ReadOnly = true;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            IQueryable<Groups> iqp = dbm.Groups;
            if (checkBoxByTypeOfActivity.Checked)
            {
                iqp = iqp.Where(x => x.TypeOfActivity.Contains(textBoxSearchTypeOfActivity.Text));
            }
            if (checkBoxByNumberOfChildren.Checked)
            {
                int from;
                if (Int32.TryParse(textBoxSearchMinAgeInGroup.Text, out from))
                    iqp = iqp.Where(x => x.MinAgeInTheGroup >= from);
                int to;
                if (Int32.TryParse(textBoxSearchMaxAgeInGroup.Text, out to))
                    iqp = iqp.Where(x => x.MaxAgeInTheGroup <= to);
            }
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderByDescending(x => x.MaxNumberOfChildren);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.CostOfaMonthOfTraining);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderByDescending(x => x.MaxNumberOfChildren).ThenBy(x => x.CostOfaMonthOfTraining);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.CostOfaMonthOfTraining).ThenByDescending(x => x.MaxNumberOfChildren);
            }
            bindingSourceGroups.DataSource = iqp;
        }
    }
}
