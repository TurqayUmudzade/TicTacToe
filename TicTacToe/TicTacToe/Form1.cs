using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool player1turn = true;
        int player1Score = 0;
        int player2Score = 0;
        bool won = false;

        List<string> myList = new List<string>();







        public TicTacToe()
        {

            InitializeComponent();
            player1ScoreLabel.Text = player1Score.ToString();
            player2ScoreLabel.Text = player2Score.ToString();


        }

        private void Tic(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player1turn == true)
                {
                    button.Text = "X";
                    player1turn = false;
                    label2.Text = "Player 2";
                    myList.Add("X");
                    CheckforWin();



                }
                else if (player1turn != true)
                {
                    button.Text = "O";
                    player1turn = true;
                    label2.Text = "Player 1";
                    myList.Add("O");
                    CheckforWin();
                }
            }
        }

        private void CheckforWin()
        {

            if (myList.Count >= 5)
            {

                // HORIZONTAL
                if (button1.Text != "" && button2.Text != "" && button2.Text != "")
                {
                    if (button1.Text == button2.Text && button2.Text == button3.Text)
                    {
                        button1.BackColor = Color.LightGreen;
                        button2.BackColor = Color.LightGreen;
                        button3.BackColor = Color.LightGreen;
                        Win(button1);


                    }
                }

                if (button4.Text != "" && button5.Text != "" && button6.Text != "")
                {
                    if (button4.Text == button5.Text && button5.Text == button6.Text)
                    {
                        button4.BackColor = Color.LightGreen;
                        button5.BackColor = Color.LightGreen;
                        button6.BackColor = Color.LightGreen;
                        Win(button4);
                    }
                }

                if (button7.Text != "" && button8.Text != "" && button9.Text != "")
                {
                    if (button7.Text == button8.Text && button8.Text == button9.Text)
                    {
                        button7.BackColor = Color.LightGreen;
                        button8.BackColor = Color.LightGreen;
                        button9.BackColor = Color.LightGreen;
                        Win(button7);
                    }
                }

                //VERTICAL
                if (button1.Text != "" && button4.Text != "" && button7.Text != "")
                {

                    if (button1.Text == button4.Text && button4.Text == button7.Text)
                    {
                        button1.BackColor = Color.LightGreen;
                        button4.BackColor = Color.LightGreen;
                        button7.BackColor = Color.LightGreen;
                        Win(button1);
                    }
                }
                if (button2.Text != "" && button5.Text != "" && button8.Text != "")
                {
                    if (button2.Text == button5.Text && button5.Text == button8.Text)
                    {
                        button2.BackColor = Color.LightGreen;
                        button5.BackColor = Color.LightGreen;
                        button8.BackColor = Color.LightGreen;
                        Win(button2);
                    }
                }
                if (button3.Text != "" && button6.Text != "" && button9.Text != "")
                {
                    if (button3.Text == button6.Text && button6.Text == button9.Text)
                    {
                        button3.BackColor = Color.LightGreen;
                        button6.BackColor = Color.LightGreen;
                        button9.BackColor = Color.LightGreen;
                        Win(button3);
                    }
                }
                // Diagonal
                if (button1.Text != "" && button5.Text != "" && button9.Text != "")
                {
                    if (button1.Text == button5.Text && button5.Text == button9.Text)
                    {
                        button1.BackColor = Color.LightGreen;
                        button5.BackColor = Color.LightGreen;
                        button9.BackColor = Color.LightGreen;
                        Win(button1);
                    }
                }
                if (button3.Text != "" && button5.Text != "" && button7.Text != "")
                {

                    if (button3.Text == button5.Text && button5.Text == button7.Text)
                    {
                        button3.BackColor = Color.LightGreen;
                        button5.BackColor = Color.LightGreen;
                        button7.BackColor = Color.LightGreen;
                        Win(button1);

                    }
                }



            }
            if (myList.Count == 9)
            {
                Draw();
            }
        }

        private void Win(Button button)
        {


            if (button.Text == "X")
            {
                player1Score++;
                MessageBox.Show("Player 1 wins");
                won = true;
                newGame();
                player1ScoreLabel.Text = player1Score.ToString();

            }
            else
            {
                player2Score++;
                MessageBox.Show("Player 2 wins");
                won = true;
                newGame();

                player2ScoreLabel.Text = player2Score.ToString();
            }
        }

        private void Draw()
        {
            if (won == false)
                MessageBox.Show("Its a Draw");
            newGame();

        }

        private void newGame()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "";
                myList.Clear();
                button.BackColor = Color.White;
            }
            won = false;
        }

       
    }
}
