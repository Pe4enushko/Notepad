using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнотец
{
    public partial class Mainform : Form
    {
        public string Lang;
        public Mainform(MsBoxForm f)
        {
            
        }
        public Mainform()
        {
            InitializeComponent();
            if (Properties.Settings.Default.BgPath != "") { pb_bg.Image = Image.FromFile(Properties.Settings.Default.BgPath); }
            if (Properties.Settings.Default.DefLang != "") {Lang = Properties.Settings.Default.DefLang;}
            LangChangeHelper(Properties.Settings.Default.DefLang);
        }
        public string[] ReadLocalisation(string Language) // Language должно означать либо English либо Русский (я не завёз больше языков)
        {
            int i = 0;
            string[] Setts = new string[12]; // Главное - добавлять сюда элементы когда появляются новые слова
            using (StreamReader LocRead = new StreamReader($@"{Environment.CurrentDirectory}\Localisation.txt", Encoding.Default, false)) // Файлик с локализацией кидать в ту же папку, где валяется exe
            {
                try
                {
                    while (LocRead.Peek() != -1)
                    {
                        if (LocRead.ReadLine() == Language)
                        {
                            while (LocRead.Peek() != '#')
                            {
                                Setts[i] = LocRead.ReadLine();
                                i++;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return Setts;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // Сохранение
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "Text files (*.txt)|**.txt";
            save.ShowDialog();

            if (save.FileName.Length > 0)
            {
                rtb.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) // Загрузка файла
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text | *.txt"; // В каком формате сохраняем
            string path;
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = Path.Combine(Path.GetDirectoryName(open.FileName), open.FileName); // Путь к файлу + название файла
                rtb.LoadFile(path, RichTextBoxStreamType.PlainText);
            }   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Выход
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) // Меняем шрифт
        {
            FontDialog font = new FontDialog();
            font.Font = rtb.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                rtb.Font = font.Font;
                if (rtb.Text.Length != 0)
                {
                    rtb.Text.Replace(rtb.Text, rtb.Text);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e) // Изменение цвета шрифта
        {
            ColorDialog color = new ColorDialog();
            color.Color = rtb.ForeColor;   // Грузим в меню цвет, который выбран сейчас
            if (color.ShowDialog() == DialogResult.OK)
            {
                rtb.ForeColor = color.Color; // Меняем цвет на выбранный
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // Кратко про блокнот
        {
            MsBoxForm box = new MsBoxForm();
            string[] Names = new string[12];
            Names = ReadLocalisation(Lang);
            box.msg1 = Names[10];
            box.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Environment.CurrentDirectory);
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            string path;
            if (img.ShowDialog() == DialogResult.OK)
            {

                path = Path.Combine(Path.GetDirectoryName(img.FileName), img.FileName);
                pb_bg.Image = Image.FromFile(path);

                Properties.Settings.Default.BgPath = path;
            }
            Properties.Settings.Default.Save();
        }

        private void CustomizationMenu_Click(object sender, EventArgs e)
        {

        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pb_bg.Image = Image.FromFile(Properties.Settings.Default.BgPath);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lang = "English";
            LangChangeHelper(Lang);
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lang = "Русский";
            LangChangeHelper(Lang);
        }
        private void LangChangeHelper(string lng)
        {
            string[] Names = new string[10];
            Names = ReadLocalisation(lng);
            Menu.Text = Names[0];
            SaveTool.Text = Names[1];
            Loadtool.Text = Names[2];
            Exit.Text = Names[3];
            CustomizationMenu.Text = Names[4];
            FontChanger.Text = Names[5];
            ColorChanger.Text = Names[6];
            BackgroundChanger.Text = Names[7];
            About.Text = Names[8];
            LanguageChanger.Text = Names[9];

            Properties.Settings.Default.DefLang = Lang;
            Properties.Settings.Default.Save();
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }
    }
}
