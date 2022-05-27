using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
    public partial class TipItGame : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;


        public TipItGame()
        {
            InitializeComponent();
            this.computerNumber = random.Next(10);
        }

        private void Reset()
        {
            computerNumber = random.Next(10);
        }



        private void CheckAnswer(int computerNumber, int userNumber)

        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Угадай число", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reset();
                    UserAnswer.Clear();

                }
                else
                {
                    Close();
                }

            }
            if (computerNumber > userNumber )
            {
                MessageBox.Show($"Загаданное число больше, попробуйте еще раз", "Угадай число",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserAnswer.Clear();

            }
            if (computerNumber < userNumber)
            {
                MessageBox.Show($"Загаданное число меньше, попробуйте еще раз", "Угадай число",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserAnswer.Clear();
            }


        }


        private void UserAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                this.userNumber = int.Parse(UserAnswer.Text);                
                CheckAnswer(computerNumber,userNumber);
            }


        }
    }
}
