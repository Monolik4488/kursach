namespace Bedroom
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыЛВСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cable = new System.Windows.Forms.ToolStripMenuItem();
            this.router = new System.Windows.Forms.ToolStripMenuItem();
            this.server = new System.Windows.Forms.ToolStripMenuItem();
            this.Computer = new System.Windows.Forms.ToolStripMenuItem();
            this.Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.Arrow = new System.Windows.Forms.ToolStripMenuItem();
            this.Size_text = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Drag_and_Drop = new System.Windows.Forms.ToolStripMenuItem();
            this.Turning = new System.Windows.Forms.ToolStripMenuItem();
            this.Change_Size = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Element = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_map = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.элементыЛВСToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.Clear_map});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // элементыЛВСToolStripMenuItem
            // 
            this.элементыЛВСToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cable,
            this.router,
            this.server,
            this.Computer,
            this.Windows,
            this.Arrow,
            this.Size_text});
            this.элементыЛВСToolStripMenuItem.Name = "элементыЛВСToolStripMenuItem";
            this.элементыЛВСToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.элементыЛВСToolStripMenuItem.Text = "Элементы лвс";
            // 
            // cable
            // 
            this.cable.Name = "cable";
            this.cable.Size = new System.Drawing.Size(216, 26);
            this.cable.Text = "кабель";
            this.cable.Click += new System.EventHandler(this.change_mode);
            // 
            // router
            // 
            this.router.Name = "router";
            this.router.Size = new System.Drawing.Size(216, 26);
            this.router.Text = "роутер";
            this.router.Click += new System.EventHandler(this.change_mode);
            // 
            // server
            // 
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(216, 26);
            this.server.Text = "сервер";
            this.server.Click += new System.EventHandler(this.change_mode);
            // 
            // Computer
            // 
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(216, 26);
            this.Computer.Text = "Компьютер";
            this.Computer.Click += new System.EventHandler(this.change_mode);
            // 
            // Windows
            // 
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(216, 26);
            this.Windows.Text = "коммутатор";
            this.Windows.Click += new System.EventHandler(this.change_mode);
            // 
            // Arrow
            // 
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(216, 26);
            this.Arrow.Text = "Стрелка";
            this.Arrow.Click += new System.EventHandler(this.change_mode);
            // 
            // Size_text
            // 
            this.Size_text.Name = "Size_text";
            this.Size_text.Size = new System.Drawing.Size(216, 26);
            this.Size_text.Text = "Надпись";
            this.Size_text.Click += new System.EventHandler(this.change_mode);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Drag_and_Drop,
            this.Turning,
            this.Change_Size,
            this.Delete_Element});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // Drag_and_Drop
            // 
            this.Drag_and_Drop.Name = "Drag_and_Drop";
            this.Drag_and_Drop.Size = new System.Drawing.Size(209, 26);
            this.Drag_and_Drop.Text = "Переместить";
            this.Drag_and_Drop.Click += new System.EventHandler(this.change_mode);
            // 
            // Turning
            // 
            this.Turning.Name = "Turning";
            this.Turning.Size = new System.Drawing.Size(209, 26);
            this.Turning.Text = "Поворот";
            this.Turning.Click += new System.EventHandler(this.change_mode);
            // 
            // Change_Size
            // 
            this.Change_Size.Name = "Change_Size";
            this.Change_Size.Size = new System.Drawing.Size(209, 26);
            this.Change_Size.Text = "Изменить размер";
            this.Change_Size.Click += new System.EventHandler(this.change_mode);
            // 
            // Delete_Element
            // 
            this.Delete_Element.Name = "Delete_Element";
            this.Delete_Element.Size = new System.Drawing.Size(209, 26);
            this.Delete_Element.Text = "Удалить элемент";
            this.Delete_Element.Click += new System.EventHandler(this.change_mode);
            // 
            // Clear_map
            // 
            this.Clear_map.Name = "Clear_map";
            this.Clear_map.Size = new System.Drawing.Size(85, 24);
            this.Clear_map.Text = "Очистить";
            this.Clear_map.Click += new System.EventHandler(this.clear);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 653);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 653);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ЛВС";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элементыЛВСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cable;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Drag_and_Drop;
        private System.Windows.Forms.ToolStripMenuItem Turning;
        private System.Windows.Forms.ToolStripMenuItem Change_Size;
        private System.Windows.Forms.ToolStripMenuItem Clear_map;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_Element;
        private System.Windows.Forms.ToolStripMenuItem Computer;
        private System.Windows.Forms.ToolStripMenuItem Windows;
        private System.Windows.Forms.ToolStripMenuItem Arrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Size_text;
        private System.Windows.Forms.ToolStripMenuItem router;
        private System.Windows.Forms.ToolStripMenuItem server;

    }
}

