
namespace Курсовая_работа
{
    partial class FormParentsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParentsEdit));
            this.labelFio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxParentsPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxParents = new System.Windows.Forms.ComboBox();
            this.bindingSourceChildren = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(51, 102);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(42, 17);
            this.labelFio.TabIndex = 39;
            this.labelFio.Text = "ФИО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // maskedTextBoxParentsPhoneNumber
            // 
            this.maskedTextBoxParentsPhoneNumber.Location = new System.Drawing.Point(216, 52);
            this.maskedTextBoxParentsPhoneNumber.Mask = "+7 (000) 000-00-00";
            this.maskedTextBoxParentsPhoneNumber.Name = "maskedTextBoxParentsPhoneNumber";
            this.maskedTextBoxParentsPhoneNumber.Size = new System.Drawing.Size(149, 20);
            this.maskedTextBoxParentsPhoneNumber.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(229, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Номер телефона";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(12, 217);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 32);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "  Сохранить";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(216, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(151, 32);
            this.buttonCancel.TabIndex = 47;
            this.buttonCancel.Text = "  Закрыть";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(255, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ребёнок";
            // 
            // comboBoxParents
            // 
            this.comboBoxParents.DataSource = this.bindingSourceChildren;
            this.comboBoxParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParents.FormattingEnabled = true;
            this.comboBoxParents.Location = new System.Drawing.Point(213, 122);
            this.comboBoxParents.Name = "comboBoxParents";
            this.comboBoxParents.Size = new System.Drawing.Size(149, 21);
            this.comboBoxParents.TabIndex = 49;
            // 
            // bindingSourceChildren
            // 
            this.bindingSourceChildren.DataSource = typeof(Курсовая_работа.Children);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(12, 52);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(129, 20);
            this.textBoxID.TabIndex = 51;
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(12, 123);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFio.Multiline = true;
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(129, 42);
            this.textBoxFio.TabIndex = 52;
            this.textBoxFio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFio_KeyPress);
            // 
            // FormParentsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(393, 280);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxParents);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.maskedTextBoxParentsPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFio);
            this.Name = "FormParentsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование родителей";
            this.Load += new System.EventHandler(this.FormParentsEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParentsPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxParents;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.BindingSource bindingSourceChildren;
    }
}