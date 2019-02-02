using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        enum PlayerTurn { None, Player1, Player2 };

        PlayerTurn turn;

        void OnNewGame()
        {
            turn = PlayerTurn.Player1;
            ShowTurn();
        }

        void ShowTurn()
        {
            string status = "";
            if (turn == PlayerTurn.Player1)
                status = "Turn: Player 1";
            else
                status = "Turn: Player 2";

            lblStatus.Text = status;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;

            // prevents image overright
            if (p.Image != null)
                return;

            if (turn == PlayerTurn.Player1)
                p.Image = player1.Image;
            else
                p.Image = player2.Image;

            // Change turns
            turn = (PlayerTurn.Player1 == turn) ? 
                PlayerTurn.Player2 : PlayerTurn.Player1;

            ShowTurn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnNewGame();
        }
    }
}
