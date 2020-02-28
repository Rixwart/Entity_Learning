using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Entity_learn
{
    public partial class FormTesting : Form
    {
        int time = 150000;
        int minets=0;
        int seconds = 30;
        int QesNow = 0;//текущий вопрос
        int[] answers = new int[10] { 0,0,0,0,0,0,0,0,0,0};//правильные ответы
        int[] posmemory = new int[10] {7,7,7,7,7,7,7,7,7,7};//отмеченные ответы
        int[] qestions = new int[] { 0 , 6 ,  12 , 18 , 24 , 30 , 36 , 42 , 48, 54};

        public FormTesting()
        {
            InitializeComponent();
            
            timer1.Interval = 1000;       
            ZeroRadio();
            QesNow = 0;
            QestionSetter(0);
        }

        void ZeroRadio()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }//Сбрасывает радио баттоны

        void QestionSetter(int qes)
        {
            label1.Text = File.ReadLines("test\\qestions.txt").Skip(qestions[qes]).First();
            radioButton1.Text = File.ReadLines("test\\qestions.txt").Skip(qestions[qes] + 1).First();
            radioButton2.Text = File.ReadLines("test\\qestions.txt").Skip(qestions[qes] + 2).First();
            radioButton3.Text = File.ReadLines("test\\qestions.txt").Skip(qestions[qes] + 3).First();
            radioButton4.Text = File.ReadLines("test\\qestions.txt").Skip(qestions[qes] + 4).First();
            answers[qes] = int.Parse(File.ReadLines("test\\qestions.txt").Skip(qestions[qes] + 5).First());
        }//Вносит вопросы

        void ButtonChangeColor(int i)
        {
            switch (i)
            {
                case 0: button1.BackColor = Color.Red; break;
                case 1: button2.BackColor = Color.Red; break;
                case 2: button3.BackColor = Color.Red; break;
                case 3: button4.BackColor = Color.Red; break;
                case 4: button5.BackColor = Color.Red; break;
                case 5: button6.BackColor = Color.Red; break;
                case 6: button7.BackColor = Color.Red; break;
                case 7: button8.BackColor = Color.Red; break;
                case 8: button9.BackColor = Color.Red; break;
                case 9: button10.BackColor = Color.Red; break;
            }
        }//Меняет цвет кнопок

        void PosMemSetRadio(int qes)
        {
            switch (posmemory[qes])
            {
                case 1: radioButton1.Checked = true; break;
                case 2: radioButton2.Checked = true; break;
                case 3: radioButton3.Checked = true; break;
                case 4: radioButton4.Checked = true; break;
            }
        }//

        private void button11_Click(object sender, EventArgs e)//Проверка правильных ответов
        {
            timer1.Stop();
            int right = 0;
            for (int i = 0; i < 10; i++)
            {
                if (answers[i] == posmemory[i]) right++; else ButtonChangeColor(i);
            }
            label2.Visible = true;
            label2.Text = "Правильных ответов: "+right.ToString();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            button14.Visible = true;

        }

        private void button13_Click(object sender, EventArgs e)//Выход из приложения
        {
         if(MessageBox.Show("Вы уверены, что хотите выйти?","Выход",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)   
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)//Выход в главное мню
        {
            this.Hide();
            MainMenycs mn = new MainMenycs();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ZeroRadio();
            QesNow = 0;
            QestionSetter(0);
            PosMemSetRadio(0);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 1;
            QestionSetter(1);
            PosMemSetRadio(1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 2;
            QestionSetter(2);
            PosMemSetRadio(2);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 3;
            QestionSetter(3);
            PosMemSetRadio(3);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 4;
            QestionSetter(4);
            PosMemSetRadio(4);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 5;
            QestionSetter(5);
            PosMemSetRadio(5);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 6;
            QestionSetter(6);
            PosMemSetRadio(6);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 7;
            QestionSetter(7);
            PosMemSetRadio(7);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 8;
            QestionSetter(8);
            PosMemSetRadio(8);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ZeroRadio();
            QesNow = 9;
            QestionSetter(9);
            PosMemSetRadio(9);
            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            posmemory[QesNow] = 1;
            ButtonChecked();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            posmemory[QesNow] = 2;
            ButtonChecked();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            posmemory[QesNow] = 3;
            ButtonChecked();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            posmemory[QesNow] = 4;
            ButtonChecked();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            time = 150000;
            minets = 0;
            seconds = 30;
            timer1.Start();

            label2.Visible = false;
            answers = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            posmemory = new int[10] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            button14.Visible = false;

            ZeroRadio();
            QesNow = 0;
            QestionSetter(0);

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button10.BackColor = Color.Gray;

        }//Кнопка заного

        void ButtonChecked()
        {
            switch (QesNow)
            {
                case 0: button1.BackColor = Color.Yellow; break;
                case 1: button2.BackColor = Color.Yellow; break;
                case 2: button3.BackColor = Color.Yellow; break;
                case 3: button4.BackColor = Color.Yellow; break;
                case 4: button5.BackColor = Color.Yellow; break;
                case 5: button6.BackColor = Color.Yellow; break;
                case 6: button7.BackColor = Color.Yellow; break;
                case 7: button8.BackColor = Color.Yellow; break;
                case 8: button9.BackColor = Color.Yellow; break;
                case 9: button10.BackColor = Color.Yellow; break;
                default: break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time -= 1000;
            --seconds;
            if (minets == 0 && seconds == 0)
            {
                timer1.Stop();
                button11.PerformClick();
                label3.Text = "Время вышло";
                return;
            }
            if (seconds == 0) { minets--; seconds = 60; }
            
            label3.Text = minets.ToString() + ":" + seconds.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            pictureBox1.Visible = false;
            timer1.Start();
        }//Начать тест

        private void button16_Click(object sender, EventArgs e)
        {
            button12.PerformClick();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button13.PerformClick();
        }
    }
}
