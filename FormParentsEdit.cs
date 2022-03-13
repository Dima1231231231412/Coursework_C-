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
    public partial class FormParentsEdit : Form
    {
        Parents p;
        DatabaseMain dbm;
        public FormParentsEdit(Parents _p, DatabaseMain _dbm)
        {
            InitializeComponent();
            p = _p;
            dbm = _dbm;   
        }

        private void objectToData()
        {
            textBoxID.Text = p.ID.ToString();
            textBoxFio.Text = p.FioParents;
            maskedTextBoxParentsPhoneNumber.Text = p.ParentsPhoneNumber;
            if (p.Children != null)
                comboBoxParents.Text = p.Children.FioChildren;
        }
        private bool dataToObject()
        {
            InputError ie = new InputError();
            if (maskedTextBoxParentsPhoneNumber.Text.Length == 18)
                p.ParentsPhoneNumber = maskedTextBoxParentsPhoneNumber.Text;
            else
            {
               ie.inputErrorMaskedTextBox(maskedTextBoxParentsPhoneNumber);
                return false;

            }
            if (textBoxFio.Text.Length < 10)
            {
                ie.inputErrorTextBox(textBoxFio);
                return false;
            }
            else
                p.FioParents = textBoxFio.Text;

            p.Children = (Children)bindingSourceChildren.Current;
            p.Children.FioChildren = comboBoxParents.Text;
            return true;
        }


        private void FormParentsEdit_Load(object sender, EventArgs e)
        {
            bindingSourceChildren.DataSource = dbm.Children;
            objectToData();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
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
