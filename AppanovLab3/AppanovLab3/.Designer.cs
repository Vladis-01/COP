namespace AppanovLab3
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
            this.components = new System.ComponentModel.Container();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эксельФотографииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вордСтудентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пДФСтудентыИНаправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.component31 = new Laboratory1.Components.Component3();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эксельФотографииToolStripMenuItem,
            this.вордСтудентыToolStripMenuItem,
            this.пДФСтудентыИНаправленияToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // эксельФотографииToolStripMenuItem
            // 
            this.эксельФотографииToolStripMenuItem.Name = "эксельФотографииToolStripMenuItem";
            this.эксельФотографииToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.эксельФотографииToolStripMenuItem.Text = "Эксель - фотографии";
            this.эксельФотографииToolStripMenuItem.Click += new System.EventHandler(this.эксельФотографииToolStripMenuItem_Click);
            // 
            // вордСтудентыToolStripMenuItem
            // 
            this.вордСтудентыToolStripMenuItem.Name = "вордСтудентыToolStripMenuItem";
            this.вордСтудентыToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.вордСтудентыToolStripMenuItem.Text = "Ворд - студенты";
            this.вордСтудентыToolStripMenuItem.Click += new System.EventHandler(this.вордСтудентыToolStripMenuItem_Click);
            // 
            // пДФСтудентыИНаправленияToolStripMenuItem
            // 
            this.пДФСтудентыИНаправленияToolStripMenuItem.Name = "пДФСтудентыИНаправленияToolStripMenuItem";
            this.пДФСтудентыИНаправленияToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.пДФСтудентыИНаправленияToolStripMenuItem.Text = "ПДФ - студенты и направления";
            this.пДФСтудентыИНаправленияToolStripMenuItem.Click += new System.EventHandler(this.пДФСтудентыИНаправленияToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.направленияToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.направленияToolStripMenuItem.Text = "Направления";
            this.направленияToolStripMenuItem.Click += new System.EventHandler(this.направленияToolStripMenuItem_Click);
            // 
            // component31
            // 
            this.component31.ContextMenuStrip = this.contextMenuStrip1;
            this.component31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.component31.Location = new System.Drawing.Point(0, 0);
            this.component31.Margin = new System.Windows.Forms.Padding(2);
            this.component31.Name = "component31";
            this.component31.SelectedIndex = -1;
            this.component31.Size = new System.Drawing.Size(855, 450);
            this.component31.TabIndex = 2;
            this.component31.KeyDown += new System.Windows.Forms.KeyEventHandler(this.component31_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.component31);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.component31_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эксельФотографииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вордСтудентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пДФСтудентыИНаправленияToolStripMenuItem;
        private Laboratory1.Components.Component3 component31;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
    }
}

