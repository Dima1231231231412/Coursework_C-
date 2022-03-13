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
    public partial class FormTeachers : Form
    {
        DatabaseMain dbm;
        public FormTeachers(DatabaseMain _dbm)
        {
            InitializeComponent();
            dbm = _dbm;
            dataGridViewTeachers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewTeachers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewTeachers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            comboBox1.Items.AddRange(new string[] { "По стажу", "По дню рождения", "По фамилии" });
            comboBox2.Items.AddRange(new string[] { "По стажу", "По дню рождения", "По фамилии" });
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Teachers t;
            if (bindingSourceTeachers.Current != null)
            {
                t = (Teachers)bindingSourceTeachers.Current;
                FormTeachersEdit fte = new FormTeachersEdit(t);
                fte.ShowDialog();
                if (fte.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bindingSourceTeachers.ResetCurrentItem();
                    dbm.SubmitChanges();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers()
            {
                Specialization = "Учитель по аэробике",
                DateOfBirth = new DateTime(2000, 1, 1),
                WorkExperience = 12,
                Salary = 12500
            };
            FormTeachersEdit fte = new FormTeachersEdit(t);
            fte.ShowDialog();
            if (fte.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bindingSourceTeachers.Add(t);
                dbm.SubmitChanges();
            }
        }
        private void FormTeachers_Load(object sender, EventArgs e)
        {
            bindingSourceTeachers.DataSource = dbm.Teachers;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Teachers t;
            if (bindingSourceTeachers.Current != null)
            {
                t = (Teachers)bindingSourceTeachers.Current;
                if (t.Schedule.Count() != 0)
                {
                    MessageBox.Show("Удаление записи невозможно, так как имеется связь с таблицей 'Расписание'", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Удалить учителя с ФИО '{t.Fio}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        bindingSourceTeachers.Remove(t);
                        dbm.SubmitChanges();
                    }
                }
            }
        }
     

        private void checkBoxByFio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByFio.Checked)
                textBoxSearchFio.ReadOnly = false;
            else
                textBoxSearchFio.ReadOnly = true;
        }

        private void checkBoxBySalary_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBySalary.Checked)
            {
                textBoxSearchSalaryFrom.ReadOnly = false;
                textBoxSearchSalaryTo.ReadOnly = false;
            }
            else
            {
                textBoxSearchSalaryFrom.ReadOnly = true;
                textBoxSearchSalaryTo.ReadOnly = true;
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

        private void buttonSort_Click(object sender, EventArgs e)
        {
            IQueryable<Teachers> iqp = dbm.Teachers;
            if (checkBoxByFio.Checked)
            {
                iqp = iqp.Where(x => x.Fio.Contains(textBoxSearchFio.Text));
            }
            if (checkBoxBySalary.Checked)
            {
                int from;
                if (Int32.TryParse(textBoxSearchSalaryFrom.Text, out from))
                    iqp = iqp.Where(x => x.Salary >= from);
                int to;
                if (Int32.TryParse(textBoxSearchSalaryTo.Text, out to))
                    iqp = iqp.Where(x => x.Salary <= to);

            }
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.WorkExperience);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.DateOfBirth);
            }
            if (comboBox1.SelectedIndex == 2 || comboBox2.SelectedIndex == 2)
            {
                iqp = iqp.OrderBy(x => x.Fio);
            }

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.WorkExperience).ThenBy(x => x.DateOfBirth);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.DateOfBirth).ThenBy(x => x.WorkExperience);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                iqp = iqp.OrderBy(x => x.WorkExperience).ThenBy(x => x.Fio);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.Fio).ThenBy(x => x.WorkExperience);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                iqp = iqp.OrderBy(x => x.DateOfBirth).ThenBy(x => x.Fio);
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.Fio).ThenBy(x => x.DateOfBirth);
            }

            bindingSourceTeachers.DataSource = iqp;
        }
    }
}
