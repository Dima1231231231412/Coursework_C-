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
    public partial class FormSchedule : Form
    {
        DatabaseMain dbm;
        public FormSchedule(DatabaseMain _dbm)
        {
            InitializeComponent();
            dbm = _dbm;
            dataGridViewSchedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewSchedule.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewSchedule.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            comboBox1.Items.AddRange(new string[] { "По группам", "По дате и времени занятий" });
            comboBox2.Items.AddRange(new string[] { "По группам", "По дате и времени занятий" });
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Schedule s;
            if (bindingSourceSchedule.Current != null)
            {
                s = (Schedule)bindingSourceSchedule.Current;
                FormScheduleEdit fse = new FormScheduleEdit(s, dbm);
                fse.ShowDialog();
                if (fse.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    return;
                else if (fse.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bindingSourceSchedule.ResetCurrentItem();
                    dbm.SubmitChanges();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule()
            {
                ClassDateTime = new DateTime(2020, 9, 1, 10, 30, 0),
                Duration_minutes = 60
            };
            FormScheduleEdit fse = new FormScheduleEdit(s, dbm);
            fse.ShowDialog();
            if (fse.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bindingSourceSchedule.Add(s);
                dbm.SubmitChanges();
            }
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            bindingSourceSchedule.DataSource = dbm.Schedule;
            dataGridViewSchedule.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "formatdata",
                HeaderText = "Дата и время",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Schedule s;
            if (bindingSourceSchedule.Current != null)
            {
                s = (Schedule)bindingSourceSchedule.Current;
                DialogResult dr = MessageBox.Show($"Удалить расписание группы '{s.Groups.Name}' у учителя '{s.Teachers.Fio}' ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    bindingSourceSchedule.Remove(s);
                    dbm.SubmitChanges();
                }
            }
        }

        private void checkBoxByClassDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByClassDateTime.Checked)
                dateTimePickerSearch.Enabled = true;
            else
                dateTimePickerSearch.Enabled = false;
        }

        private void checkBoxByDuration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxByDuration.Checked)
            {
                textBoxSearchDurationFrom.ReadOnly = false;
                textBoxSearchDurationTo.ReadOnly = false;
            }
            else
            {
                textBoxSearchDurationFrom.ReadOnly = true;
                textBoxSearchDurationTo.ReadOnly = true;
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
            IQueryable<Schedule> iqp = dbm.Schedule;
            if (checkBoxByClassDateTime.Checked)
            {
                    iqp = iqp.Where(x => x.ClassDateTime == dateTimePickerSearch.Value);
            }
            if (checkBoxByDuration.Checked)
            {
                int from;
                if (Int32.TryParse(textBoxSearchDurationFrom.Text, out from))
                    iqp = iqp.Where(x => x.Duration_minutes >= from);
                int to;
                if (Int32.TryParse(textBoxSearchDurationTo.Text, out to))
                    iqp = iqp.Where(x => x.Duration_minutes <= to);

            }
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.Groups.Name);
            }
            if (comboBox1.SelectedIndex == 1 || comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.ClassDateTime);
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                iqp = iqp.OrderBy(x => x.Groups.Name).ThenBy(x => x.ClassDateTime);
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                iqp = iqp.OrderBy(x => x.ClassDateTime).ThenBy(x => x.Groups.Name);
            }
            bindingSourceSchedule.DataSource = iqp;
        }

    }
}
