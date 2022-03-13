
namespace Курсовая_работа
{
    partial class FormChildrenEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildrenEdit));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelFio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxChildsPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Домашний адрес";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(12, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 32);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "  Сохранить";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(217, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 32);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "  Закрыть";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(24, 82);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFio.Multiline = true;
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(134, 42);
            this.textBoxFio.TabIndex = 29;
            this.textBoxFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFio_KeyPress);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(134, 27);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(120, 20);
            this.textBoxID.TabIndex = 28;
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(65, 61);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(42, 17);
            this.labelFio.TabIndex = 23;
            this.labelFio.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // textBoxHomeAddress
            // 
            this.textBoxHomeAddress.Location = new System.Drawing.Point(24, 153);
            this.textBoxHomeAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHomeAddress.Multiline = true;
            this.textBoxHomeAddress.Name = "textBoxHomeAddress";
            this.textBoxHomeAddress.Size = new System.Drawing.Size(134, 47);
            this.textBoxHomeAddress.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(244, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Номер телефона";
            // 
            // maskedTextBoxChildsPhoneNumber
            // 
            this.maskedTextBoxChildsPhoneNumber.Location = new System.Drawing.Point(228, 127);
            this.maskedTextBoxChildsPhoneNumber.Mask = "+7 (000) 000-00-00";
            this.maskedTextBoxChildsPhoneNumber.Name = "maskedTextBoxChildsPhoneNumber";
            this.maskedTextBoxChildsPhoneNumber.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxChildsPhoneNumber.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(228, 82);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(2021, 5, 4, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 44;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.bindingSourceGroups;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(228, 179);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(134, 21);
            this.comboBoxGroup.TabIndex = 45;
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(Курсовая_работа.Groups);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(271, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Группа";
            // 
            // FormChildrenEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxChildsPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHomeAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.label1);
            this.Name = "FormChildrenEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование детей";
            this.Load += new System.EventHandler(this.FormChildrenEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHomeAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxChildsPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
    }
}