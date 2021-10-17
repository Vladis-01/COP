namespace Lab1Appanov
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.outputControl1 = new Lab1Appanov.Components.OutputControl();
            this.selectionControl1 = new Lab1Appanov.Components.SelectionControl();
            this.inputControl1 = new Lab1Appanov.Components.InputControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputControl1
            // 
            this.outputControl1.Location = new System.Drawing.Point(324, 34);
            this.outputControl1.Name = "outputControl1";
            this.outputControl1.Size = new System.Drawing.Size(265, 227);
            this.outputControl1.TabIndex = 5;
            // 
            // selectionControl1
            // 
            this.selectionControl1.Location = new System.Drawing.Point(0, 0);
            this.selectionControl1.Name = "selectionControl1";
            this.selectionControl1.Size = new System.Drawing.Size(217, 49);
            this.selectionControl1.TabIndex = 0;
            this.selectionControl1.value = "System.Windows.Forms.ListBox+SelectedObjectCollection";
            // 
            // inputControl1
            // 
            this.inputControl1.FirstDate = null;
            this.inputControl1.LastDate = null;
            this.inputControl1.Location = new System.Drawing.Point(8, 206);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(321, 127);
            this.inputControl1.TabIndex = 4;
            this.inputControl1.value = new System.DateTime(2021, 9, 12, 19, 34, 58, 325);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.outputControl1);
            this.Controls.Add(this.selectionControl1);
            this.Controls.Add(this.inputControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private Components.SelectionControl selectionControl1;
		private Components.InputControl inputControl1;

        #endregion

        private Components.OutputControl outputControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

