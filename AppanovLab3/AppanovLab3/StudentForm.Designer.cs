namespace AppanovLab3
{
    partial class StudentForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.universityComboBoxDirection = new VisualComponents.UniversityComboBox();
            this.labelDirection = new System.Windows.Forms.Label();
            this.universityTextBoxEmail = new VisualComponents.UniversityTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(118, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Введите имя";
            // 
            // universityComboBoxDirection
            // 
            this.universityComboBoxDirection.item = null;
            this.universityComboBoxDirection.Location = new System.Drawing.Point(358, 23);
            this.universityComboBoxDirection.Name = "universityComboBoxDirection";
            this.universityComboBoxDirection.Size = new System.Drawing.Size(129, 27);
            this.universityComboBoxDirection.TabIndex = 4;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(363, 5);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(124, 13);
            this.labelDirection.TabIndex = 5;
            this.labelDirection.Text = "Направление обучения";
            // 
            // universityTextBoxEmail
            // 
            this.universityTextBoxEmail.example = "";
            this.universityTextBoxEmail.Location = new System.Drawing.Point(525, 23);
            this.universityTextBoxEmail.Name = "universityTextBoxEmail";
            this.universityTextBoxEmail.sample = "";
            this.universityTextBoxEmail.Size = new System.Drawing.Size(161, 27);
            this.universityTextBoxEmail.TabIndex = 6;
            this.universityTextBoxEmail.value = "";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(533, 6);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Почта";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(92, 125);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 57);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Добавить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 55);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(208, 15);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(100, 36);
            this.buttonPhoto.TabIndex = 10;
            this.buttonPhoto.Text = "Выберите фото";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.universityTextBoxEmail);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.universityComboBoxDirection);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "StudentForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private VisualComponents.UniversityComboBox universityComboBoxDirection;
        private System.Windows.Forms.Label labelDirection;
        private VisualComponents.UniversityTextBox universityTextBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPhoto;
    }
}