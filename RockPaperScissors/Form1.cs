using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public static string[] Choise = { "rock", "paper", "scissors" };
        public static string userChoise, computerChoise;
        public static int draw, win, lose = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             userChoise = Choise[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
             userChoise = Choise[2];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (userChoise == null)
            {
                label6.Text = "Вы ничего не выбрали!";
                label1.Text = "Вы ничего не выбрали!";
                label2.Text = "Вы ничего не выбрали!";
                return;
            }
            Random random = new Random();
            var comCh= random.Next(0, 3);
            if (comCh == 3) comCh = 2;
            switch(comCh)
            {
                case 0: computerChoise = Choise[0];
                    break;
                case 1: computerChoise = Choise[1];
                    break;
                case 2: computerChoise = Choise[2];
                    break;
            }

            int result = String.Compare(computerChoise, userChoise);
            if (result == 0)
            {
                int res = 1;
                ResultGame(res, computerChoise, userChoise);
            }
            else if (userChoise == Choise[0] && computerChoise == Choise[1] || 
                     userChoise == Choise[1] && computerChoise == Choise[2] || 
                     userChoise == Choise[2] && computerChoise == Choise[0])
            {
                int res = 0;
                ResultGame(res, computerChoise, userChoise);
            }
            else
            {
                int res = 2;
                ResultGame(res, computerChoise, userChoise);
            }
            
        }

        private void ResultGame(int res, string computerChoise, string userChoise)
        {
            switch(res)
            {
                case 0: label1.Text = "Вы проиграли!";
                    lose++;
                    label5.Text = "Проигрышей: " + lose;
                    break;
                case 1:
                    draw++;
                    label1.Text = "Ничья!";
                    label4.Text = "Ничьих: " + draw;
                    break;
                case 2:
                    win++;
                    label1.Text = "Вы выиграли!";
                    label3.Text = "Выигрышей: " + win;
                    break;
            }
            label2.Text = "Компьютер выбрал: " + computerChoise;
            label6.Text = "Вы выбрали: " + userChoise;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           userChoise = Choise[0];
        }
    }
}
