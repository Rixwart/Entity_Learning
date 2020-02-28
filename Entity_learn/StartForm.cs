using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_learn
{
    public partial class Entity_learn : Form
    {
        int timerCount = 0;
        int takt = 740;

        public Entity_learn()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackgroundImage = Image.FromFile("loading\\server.png");
;            
            InitializeComponent();
            timer1.Start();
            timer1.Interval = takt;
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (timerCount)
            {
                case 0:
                    loading_label.Text = "              Включам сервер.";
                     break;
                case 740:
                    loading_label.Text = "              Включам сервер..";
                    break;
                case 1480:
                    loading_label.Text = "              Включам сервер...";
                    break;
                case 2220:
                    loading_label.Text = "        Втыкаем витую пару.";
                    this.BackgroundImage = Image.FromFile("loading\\server_lan.png"); break;
                case 2960:
                    loading_label.Text = "        Втыкаем витую пару.."; break;
                case 3700:
                    loading_label.Text = "        Втыкаем витую пару..."; break;
                case 4440:
                    loading_label.Text = "            Подключаем ПК.";
                    this.BackgroundImage = Image.FromFile("loading\\server_and_PC.png"); break;
                case 5180:
                    loading_label.Text = "            Подключаем ПК..";break;
                case 5920:
                    loading_label.Text = "            Подключаем ПК...";break;
                case 6660:
                    loading_label.Text = "  Соединяем с мобильничком.";
                    this.BackgroundImage = Image.FromFile("loading\\server_and_Telephon.png"); break;
                case 7400:
                    loading_label.Text = "  Соединяем с мобильничком.."; break;
                case 8140:
                    loading_label.Text = "  Соединяем с мобильничком..."; break;
                case 8880:
                    loading_label.Text="";
                    this.BackgroundImage = Image.FromFile("loading\\loading_end.png");
                     break;
                case 10360:
                    this.Hide();
                    MainMenycs main = new MainMenycs();
                    timer1.Stop();
                    main.Show(); break;
                default: break;
            }
             timerCount += 740;
        }
        
    }
}
