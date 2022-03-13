
namespace Курсовая_работа
{
    partial class FormScheduleEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScheduleEdit));
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDuration_minutes = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerClassDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Продолжительность";
            // 
            // listBoxDuration_minutes
            // 
            this.listBoxDuration_minutes.FormattingEnabled = true;
            this.listBoxDuration_minutes.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.listBoxDuration_minutes.Location = new System.Drawing.Point(24, 122);
            this.listBoxDuration_minutes.MultiColumn = true;
            this.listBoxDuration_minutes.Name = "listBoxDuration_minutes";
            this.listBoxDuration_minutes.Size = new System.Drawing.Size(134, 82);
            this.listBoxDuration_minutes.TabIndex = 32;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(12, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 32);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "  Сохранить";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(211, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 32);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "  Закрыть";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(24, 35);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(134, 20);
            this.textBoxID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // dateTimePickerClassDateTime
            // 
            this.dateTimePickerClassDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerClassDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerClassDateTime.Location = new System.Drawing.Point(24, 79);
            this.dateTimePickerClassDateTime.MaxDate = new System.DateTime(2021, 5, 4, 0, 0, 0, 0);
            this.dateTimePickerClassDateTime.MinDate = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.dateTimePickerClassDateTime.Name = "dateTimePickerClassDateTime";
            this.dateTimePickerClassDateTime.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerClassDateTime.TabIndex = 46;
            this.dateTimePickerClassDateTime.Value = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Дата и время занятия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(255, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Учитель";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.DataSource = this.bindingSourceTeachers;
            this.comboBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(213, 35);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(149, 21);
            this.comboBoxTeacher.TabIndex = 51;
            // 
            // bindingSourceTeachers
            // 
            this.bindingSourceTeachers.DataSource = typeof(Курсовая_работа.Teachers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Группа";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.bindingSourceGroups;
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(213, 82);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(149, 21);
            this.comboBoxGroup.TabIndex = 53;
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(Курсовая_работа.Groups);
            // 
            // FormScheduleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.dateTimePickerClassDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxDuration_minutes);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "FormScheduleEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирования расписания";
            this.Load += new System.EventHandler(this.FormScheduleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDuration_minutes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerClassDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.BindingSource bindingSourceTeachers;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
    }
}