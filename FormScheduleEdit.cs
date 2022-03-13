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
    public partial class FormScheduleEdit : Form
    {
        Schedule s;
        DatabaseMain dbm;
        public FormScheduleEdit(Schedule _s,DatabaseMain _dbm)
        {
            InitializeComponent();
            s = _s;
            dbm = _dbm;
            dateTimePickerClassDateTime.MaxDate = DateTime.Now;
            dateTimePickerClassDateTime.Format = DateTimePickerFormat.Custom;
        }

        private void objectToData()
        {
            textBoxID.Text = s.ID.ToString();
            dateTimePickerClassDateTime.Value =Convert.ToDateTime(s.ClassDateTime);
            listBoxDuration_minutes.Text = s.Duration_minutes.ToString();
            if(s.Teachers != null)
            comboBoxTeacher.Text = s.Teachers.Fio;
            if (s.Groups != null)
            comboBoxGroup.Text = s.Groups.Name;
        }

        private bool dataToObject()
        {
            s.ClassDateTime = dateTimePickerClassDateTime.Value;
            s.Duration_minutes = Convert.ToInt32(listBoxDuration_minutes.Text);
            s.Teachers = (Teachers)bindingSourceTeachers.Current;
            s.Groups = (Groups)bindingSourceGroups.Current;
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataToObject())
            {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
            }

        }

        private void FormScheduleEdit_Load(object sender, EventArgs e)
        {
            bindingSourceGroups.DataSource = dbm.Groups;
            bindingSourceTeachers.DataSource = dbm.Teachers;
            objectToData();
        }
    }
}
