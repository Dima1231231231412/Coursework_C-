
namespace Курсовая_работа
{
    partial class FormTeachersEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeachersEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxSpecialization = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.numericUpWorkExperience = new System.Windows.Forms.NumericUpDown();
            this.labelCostOfaMonthOfTraining = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpWorkExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(249, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Специализация";
            // 
            // listBoxSpecialization
            // 
            this.listBoxSpecialization.FormattingEnabled = true;
            this.listBoxSpecialization.Items.AddRange(new object[] {
            "Учитель по аэробике",
            "Учитель по бальным танцам",
            "Учитель по вокалу",
            "Учитель по шахматам"});
            this.listBoxSpecialization.Location = new System.Drawing.Point(227, 35);
            this.listBoxSpecialization.MultiColumn = true;
            this.listBoxSpecialization.Name = "listBoxSpecialization";
            this.listBoxSpecialization.Size = new System.Drawing.Size(154, 56);
            this.listBoxSpecialization.TabIndex = 59;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(26, 207);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 32);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "  Сохранить";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(227, 207);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(154, 32);
            this.buttonCancel.TabIndex = 57;
            this.buttonCancel.Text = "  Закрыть";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(26, 35);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(157, 20);
            this.textBoxID.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID:";
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Location = new System.Drawing.Point(227, 157);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownSalary.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownSalary.TabIndex = 69;
            this.numericUpDownSalary.Value = new decimal(new int[] {
            12500,
            0,
            0,
            0});
            // 
            // numericUpWorkExperience
            // 
            this.numericUpWorkExperience.Location = new System.Drawing.Point(227, 111);
            this.numericUpWorkExperience.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpWorkExperience.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpWorkExperience.Name = "numericUpWorkExperience";
            this.numericUpWorkExperience.Size = new System.Drawing.Size(154, 20);
            this.numericUpWorkExperience.TabIndex = 68;
            this.numericUpWorkExperience.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // labelCostOfaMonthOfTraining
            // 
            this.labelCostOfaMonthOfTraining.AutoSize = true;
            this.labelCostOfaMonthOfTraining.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostOfaMonthOfTraining.Location = new System.Drawing.Point(277, 137);
            this.labelCostOfaMonthOfTraining.Name = "labelCostOfaMonthOfTraining";
            this.labelCostOfaMonthOfTraining.Size = new System.Drawing.Size(46, 17);
            this.labelCostOfaMonthOfTraining.TabIndex = 67;
            this.labelCostOfaMonthOfTraining.Text = "Оклад";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(277, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Стаж";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(26, 91);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFio.Multiline = true;
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(157, 38);
            this.textBoxFio.TabIndex = 72;
            this.textBoxFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(54, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "ФИО учителя";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "";
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(26, 157);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 73;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 5, 4, 0, 0, 0, 0);
            // 
            // FormTeachersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.numericUpWorkExperience);
            this.Controls.Add(this.labelCostOfaMonthOfTraining);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSpecialization);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "FormTeachersEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование учителей";
            this.Load += new System.EventHandler(this.FormTeachersEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpWorkExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxSpecialization;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.NumericUpDown numericUpWorkExperience;
        private System.Windows.Forms.Label labelCostOfaMonthOfTraining;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
    }
}