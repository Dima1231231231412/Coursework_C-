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
    public partial class FormChildrenEdit : Form
    {
        DatabaseMain dbm;
        Children c;
        public FormChildrenEdit(Children _c, DatabaseMain _dbm)
        {
            InitializeComponent();
            c = _c;
            dbm = _dbm;
            dateTimePickerDateOfBirth.MaxDate = DateTime.Now;
        }
        private void objectToData()
        {
            textBoxID.Text = c.ID.ToString();
            textBoxHomeAddress.Text = c.HomeAddress;
            dateTimePickerDateOfBirth.Value = Convert.ToDateTime(c.DateOfBirth);
            maskedTextBoxChildsPhoneNumber.Text = c.ChildsPhoneNumber;
            textBoxFio.Text = c.FioChildren;
            if (c.Groups != null)
                comboBoxGroup.Text = c.Groups.Name;
        }


        private bool dataToObject()
        {
            InputError ie = new InputError();

            if (maskedTextBoxChildsPhoneNumber.Text.Length == 18)
            {
                c.ChildsPhoneNumber = maskedTextBoxChildsPhoneNumber.Text;
            }
            else
            {
                ie.inputErrorMaskedTextBox(maskedTextBoxChildsPhoneNumber);
                return false;
            }
            if (textBoxFio.Text.Length < 10)
            {
                ie.inputErrorTextBox(textBoxFio);
                return false;
            }
            else
                c.FioChildren = textBoxFio.Text;

            if (textBoxHomeAddress.Text.Length < 5)
            {
                ie.inputErrorTextBox(textBoxHomeAddress);
                return false;
            }
             else
                c.HomeAddress = textBoxHomeAddress.Text;

            c.DateOfBirth = dateTimePickerDateOfBirth.Value;
            c.Groups = (Groups)bindingSourceGroups.Current;
            c.Groups.Name = comboBoxGroup.Text;
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataToObject())
            {
              this.DialogResult = System.Windows.Forms.DialogResult.OK;
              Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormChildrenEdit_Load(object sender, EventArgs e)
        {
            bindingSourceGroups.DataSource = dbm.Groups;
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
