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
    public partial class FormGroupsEdit : Form
    {
        Groups g;
        public FormGroupsEdit(Groups _g)
        {
            InitializeComponent();
            g = _g;
        }
        
        private void objectToData()
        {
            textBoxID.Text = g.ID.ToString();
            textBoxName.Text = g.Name;
            listBoxTypeOfActivity.Text = g.TypeOfActivity;
            numericUpDownMaxNumberOfChildren.Value = g.MaxNumberOfChildren;
            numericUpDownMaxAgeInTheGroup.Value = g.MaxAgeInTheGroup;
            numericUpDownMinAgeInTheGroup.Value = g.MinAgeInTheGroup;
            numericUpDownCostOfaMonthOfTraining.Value = g.CostOfaMonthOfTraining;
        }

        private bool dataToObject()
        {
            InputError ie = new InputError();
            if (textBoxName.Text.ToString() != "")
            {
                g.Name = textBoxName.Text;
            }
            else
            {
                ie.inputErrorTextBox(textBoxName);
                return false;
            }


            g.TypeOfActivity = listBoxTypeOfActivity.Text;
            g.MaxNumberOfChildren = Convert.ToInt32(numericUpDownMaxNumberOfChildren.Value);
            g.MaxAgeInTheGroup = Convert.ToInt32(numericUpDownMaxAgeInTheGroup.Value);
            g.MinAgeInTheGroup = Convert.ToInt32(numericUpDownMinAgeInTheGroup.Value);
            g.CostOfaMonthOfTraining = Convert.ToInt32(numericUpDownCostOfaMonthOfTraining.Value);
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

        private void FormGroupsEdit_Load(object sender, EventArgs e)
        {
            objectToData();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '1' && e.KeyChar <= '9')  || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
