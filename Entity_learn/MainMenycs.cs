using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_learn
{
    public partial class MainMenycs : Form
    {
        int max = 9;
        int now = 0;
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        bool play=false;
        int musicNum=0;

        public MainMenycs()
        {
            InitializeComponent();
        }


        private void treeView1_DoubleClick(object sender, EventArgs e)// Выбор главы для чтения
        {
            
            ChapterIndex();
            ChapterSelect();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработано для обучения созданию клиент серверных приложений. Вы можете двойным кликом выбрать главу и начать изучение.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Справка

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }//Выход

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (play)
                {
                    music.controls.pause();
                    play=false;
                }else
                {
                    musicNum = MusicBox.SelectedIndex;
                    switch (musicNum)
                    {
                        case 0: music.URL = "Music\\1.mp3"; music.controls.stop(); break;
                        case 1: music.URL = "Music\\2.mp3"; music.controls.stop(); break;
                        case 2: music.URL = "Music\\3.mp3"; music.controls.stop(); break;
                        case 3: music.URL = "Music\\4.wav"; music.controls.stop(); break;
                        default: break;
                    }
                    music.controls.play();
                    play = true;
                }
                 

            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите музыку");
            }
            
        }//Запус и остоновка музыки


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (now < max)
            {
                now++;
                ChapterSelect();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTesting ftest = new FormTesting();
            ftest.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (now > 0)
            {
                now--;
                ChapterSelect();
            }
        }

        void ChapterIndex()//Индексирование главы
        {
            switch (treeView1.SelectedNode.Text)
            {//Глава 1.
                case "Введение":
                    now = 0; break;
                case "Установка приложения SQL Server и SQL Manegment Stydio":
                    now = 1; break;
             //Глава 2.     
                case "Создание БД":
                    now = 2; break;
                case "Заполнение БД":
                    now = 3; break;
                case "Подключение БД к проекту":
                    now = 4; break;
                //Глава 3 
                case "Авторизация":
                    now = 5; break;
                case "Добавление":
                    now = 6; break;
                case "Чтение Данных":
                    now = 7; break;
                case "Редактирование":
                    now = 8; break;
                case "Удаление":
                    now = 9; break;
                default: break;
            }
        }

        void ChapterSelect()//Отображение главы
        {
            richTextBox1.Clear();
            switch (now)
            {//Глава 1.
                case 0:
                    richTextBox1.LoadFile("Chapter_1\\Введение.rtf"); break;
                case 1:
                    richTextBox1.LoadFile("Chapter_1\\Установка приложения SQL Server и SQL Manegment Stydio.rtf"); break;
            //Глава 2. 
                case 2:
                    richTextBox1.LoadFile("Chapter_2\\Создание БД.rtf"); break;
                case 3:
                    richTextBox1.LoadFile("Chapter_2\\Заполнение БД.rtf"); break;
                case 4:
                    richTextBox1.LoadFile("Chapter_2\\Подключение БД к проекту.rtf"); break;
            //Глава 3          
                case 5:
                    richTextBox1.LoadFile("Chapter_3\\Авторизация.rtf"); break;
                case 6:
                    richTextBox1.LoadFile("Chapter_3\\Добавление.rtf"); break;
                case 7:
                    richTextBox1.LoadFile("Chapter_3\\Чтение Данных.rtf"); break;
                case 8:
                    richTextBox1.LoadFile("Chapter_3\\Редактирование.rtf"); break;
                case 9:
                    richTextBox1.LoadFile("Chapter_3\\Удаление.rtf"); break;
                default: break;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана для квалификационного экзамена по ПМ.01 Разработка программных модулей программного обеспечения для компьютерных систем студентом отделения информационных технологий группы ПКС-31 Зябухиным Григорием Юрьевичем","О программе");
        }
    }
}
