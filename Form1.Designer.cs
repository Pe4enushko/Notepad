
namespace Блокнотец
{
    partial class Mainform
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
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Loadtool = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomizationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FontChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageChanger = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.CustomizationMenu,
            this.About,
            this.LanguageChanger});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(587, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTool,
            this.Loadtool,
            this.Exit});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(53, 19);
            this.Menu.Text = "Меню";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // SaveTool
            // 
            this.SaveTool.Name = "SaveTool";
            this.SaveTool.Size = new System.Drawing.Size(132, 22);
            this.SaveTool.Text = "Сохранить";
            this.SaveTool.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Loadtool
            // 
            this.Loadtool.Name = "Loadtool";
            this.Loadtool.Size = new System.Drawing.Size(132, 22);
            this.Loadtool.Text = "Загрузить";
            this.Loadtool.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CustomizationMenu
            // 
            this.CustomizationMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontChanger,
            this.ColorChanger,
            this.BackgroundChanger});
            this.CustomizationMenu.Name = "CustomizationMenu";
            this.CustomizationMenu.Size = new System.Drawing.Size(112, 19);
            this.CustomizationMenu.Text = "Персонализация";
            this.CustomizationMenu.Click += new System.EventHandler(this.CustomizationMenu_Click);
            // 
            // FontChanger
            // 
            this.FontChanger.Name = "FontChanger";
            this.FontChanger.Size = new System.Drawing.Size(113, 22);
            this.FontChanger.Text = "Шрифт";
            this.FontChanger.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // ColorChanger
            // 
            this.ColorChanger.Name = "ColorChanger";
            this.ColorChanger.Size = new System.Drawing.Size(113, 22);
            this.ColorChanger.Text = "Цвет";
            this.ColorChanger.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // BackgroundChanger
            // 
            this.BackgroundChanger.Name = "BackgroundChanger";
            this.BackgroundChanger.Size = new System.Drawing.Size(113, 22);
            this.BackgroundChanger.Text = "Фон";
            this.BackgroundChanger.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 19);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LanguageChanger
            // 
            this.LanguageChanger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.LanguageChanger.Name = "LanguageChanger";
            this.LanguageChanger.Size = new System.Drawing.Size(46, 19);
            this.LanguageChanger.Text = "Язык";
            this.LanguageChanger.Click += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BackColor = System.Drawing.SystemColors.Window;
            this.rtb.Location = new System.Drawing.Point(29, 47);
            this.rtb.Margin = new System.Windows.Forms.Padding(6);
            this.rtb.Name = "rtb";
            this.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb.Size = new System.Drawing.Size(528, 264);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // pb_bg
            // 
            this.pb_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_bg.Location = new System.Drawing.Point(0, 27);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(587, 299);
            this.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bg.TabIndex = 2;
            this.pb_bg.TabStop = false;
            this.pb_bg.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pb_bg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 326);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.pb_bg);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem SaveTool;
        private System.Windows.Forms.ToolStripMenuItem Loadtool;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ToolStripMenuItem CustomizationMenu;
        private System.Windows.Forms.ToolStripMenuItem FontChanger;
        private System.Windows.Forms.ToolStripMenuItem ColorChanger;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem BackgroundChanger;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.ToolStripMenuItem LanguageChanger;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
    }
}

