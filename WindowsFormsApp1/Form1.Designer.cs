namespace sapper
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.профиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хардкорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свояИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.музыкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продолжитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.остановитьToolStripMenuItem,
            this.продолжитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимИгрыToolStripMenuItem,
            this.свояИграToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.играToolStripMenuItem.Text = "Новая игра";
            // 
            // режимИгрыToolStripMenuItem
            // 
            this.режимИгрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкоToolStripMenuItem,
            this.сложноToolStripMenuItem,
            this.профиToolStripMenuItem,
            this.хардкорToolStripMenuItem});
            this.режимИгрыToolStripMenuItem.Name = "режимИгрыToolStripMenuItem";
            this.режимИгрыToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.режимИгрыToolStripMenuItem.Text = "Режим игры";
            // 
            // легкоToolStripMenuItem
            // 
            this.легкоToolStripMenuItem.Name = "легкоToolStripMenuItem";
            this.легкоToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.легкоToolStripMenuItem.Text = "Легко";
            this.легкоToolStripMenuItem.Click += new System.EventHandler(this.легкоToolStripMenuItem_Click);
            // 
            // сложноToolStripMenuItem
            // 
            this.сложноToolStripMenuItem.Name = "сложноToolStripMenuItem";
            this.сложноToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.сложноToolStripMenuItem.Text = "Сложно";
            this.сложноToolStripMenuItem.Click += new System.EventHandler(this.сложноToolStripMenuItem_Click);
            // 
            // профиToolStripMenuItem
            // 
            this.профиToolStripMenuItem.Name = "профиToolStripMenuItem";
            this.профиToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.профиToolStripMenuItem.Text = "Профи";
            this.профиToolStripMenuItem.Click += new System.EventHandler(this.профиToolStripMenuItem_Click);
            // 
            // хардкорToolStripMenuItem
            // 
            this.хардкорToolStripMenuItem.Name = "хардкорToolStripMenuItem";
            this.хардкорToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.хардкорToolStripMenuItem.Text = "Хардкор";
            this.хардкорToolStripMenuItem.Click += new System.EventHandler(this.хардкорToolStripMenuItem_Click);
            // 
            // свояИграToolStripMenuItem
            // 
            this.свояИграToolStripMenuItem.Name = "свояИграToolStripMenuItem";
            this.свояИграToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.свояИграToolStripMenuItem.Text = "Своя игра";
            this.свояИграToolStripMenuItem.Click += new System.EventHandler(this.свояИграToolStripMenuItem_Click_1);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.музыкаToolStripMenuItem,
            this.цветФонаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // музыкаToolStripMenuItem
            // 
            this.музыкаToolStripMenuItem.Name = "музыкаToolStripMenuItem";
            this.музыкаToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.музыкаToolStripMenuItem.Text = "Музыка";
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click_1);
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.остановитьToolStripMenuItem.Text = "Остановить";
            this.остановитьToolStripMenuItem.Click += new System.EventHandler(this.остановитьToolStripMenuItem_Click_1);
            // 
            // продолжитьToolStripMenuItem
            // 
            this.продолжитьToolStripMenuItem.Name = "продолжитьToolStripMenuItem";
            this.продолжитьToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.продолжитьToolStripMenuItem.Text = "Продолжить";
            this.продолжитьToolStripMenuItem.Click += new System.EventHandler(this.продолжитьToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Сапер";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хардкорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свояИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem музыкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продолжитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

