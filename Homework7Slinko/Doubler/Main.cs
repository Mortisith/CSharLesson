using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{

    public partial class Main : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        Stack<int> myStack = new Stack<int>();
        int counter = 0;

        public Main()
        {
            InitializeComponent();

            UpdateGameState(userNumber, random.Next(20));
        }

        private void UpdateGameState(int userNumber)
        {
            labelUserNubmer.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
        }



        private void buttonReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(20));
            myStack.Clear();
            counter = 0;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            

            UpdateGameState(userNumber *= 2);
            CheckWin();
            myStack.Push(userNumber);
            counter++;
           
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
           
            UpdateGameState(++userNumber);
            CheckWin();
            myStack.Push(userNumber);
            counter++;
            CheckWin();
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру за {counter} ходов!", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    UpdateGameState(userNumber, random.Next(20));
                }
                else
                {
                    Close();
                }
            }
        }

        private void buttonRetyrn_Click(object sender, EventArgs e)
        {
            myStack.Pop();
            userNumber = myStack.Peek();
            UpdateGameState(userNumber);
        }
    }
}
