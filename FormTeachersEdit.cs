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
    public partial class FormTeachersEdit : Form
    {
        Teachers t;
        public FormTeachersEdit(Teachers _t)
        {
            InitializeComponent();
            t = _t;
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now;
        }

        private void objectToData()
        {
            textBoxID.Text = t.ID.ToString();
            textBoxFio.Text = t.Fio;
            dateTimePickerDateOfBirth.Value = t.DateOfBirth;
            listBoxSpecialization.Text = t.Specialization;
            numericUpWorkExperience.Value = t.WorkExperience;
            numericUpDownSalary.Value = t.Salary;
        }

        private bool dataToObject()
        {
            InputError ie = new InputError();
            if (textBoxFio.Text.Length < 10)
            {
                ie.inputErrorTextBox(textBoxFio);
                return false;
            }
            else
                t.Fio = textBoxFio.Text;
   
            t.DateOfBirth = dateTimePickerDateOfBirth.Value;
            t.Specialization = listBoxSpecialization.Text;
            t.WorkExperience = Convert.ToInt32(numericUpWorkExperience.Value);
            t.Salary = Convert.ToDecimal(numericUpDownSalary.Value);
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
            else
                MessageBox.Show("Не все поля заполнены корректно!");
        }

        private void FormTeachersEdit_Load(object sender, EventArgs e)
        {
            objectToData();
        }

        private void textBoxFio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
