using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yourPoints = 0;
        int compPoints = 0;
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";
        string playerMove = String.Empty;
        string compMove = "";
        private void Start_Click(object sender, EventArgs e)
        {
            RockButton.Visible = true;
            PaperButton.Visible = true;
            ScissorsButton.Visible = true;
            ComputerChoice.Visible = true;
            ComputerChoiceLabel.Visible = true;
            YourPointsTag.Visible = true;
            YourPointsCounter.Visible = true;
            ComputerPointsTag.Visible = true;
            ComputerPointsCounter.Visible = true;
            ContinueButton.Visible = true;
            ExitButton.Visible = true;
            Start.Visible = false;
            GameLabel.Text = "Lets play!";
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            playerMove = Rock;
            Random random = new Random();
            int compRandomNum = random.Next(1, 4);

            switch (compRandomNum)
            {
                case 1:
                    compMove = Rock;
                    break;
                case 2:
                    compMove = Paper;
                    break;
                case 3:
                    compMove = Scissors;
                    break;
            }
            ComputerChoice.Text = compMove;
            if (compMove == Rock)
            {
                //ResultOfGame.ForeColor = Color.Orange;
                ResultOfGame.Text = "This game was draw!";
            }
            else if (compMove == Paper)
            {
                //ResultOfGame.ForeColor = Color.Red;
                ResultOfGame.Text = "You lose this game!";
                compPoints++;
                ComputerPointsCounter.Text = compPoints.ToString();
            }
            else if (compMove == Scissors)
            {
                //ResultOfGame.ForeColor = Color.Chartreuse;
                ResultOfGame.Text = "You win this game!";
                yourPoints++;
                YourPointsCounter.Text = yourPoints.ToString();
            }

            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
            RockButton.Enabled = false;
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerMove = Paper;
            Random random = new Random();
            int compRandomNum = random.Next(1, 4);
            switch (compRandomNum)
            {
                case 1:
                    compMove = Rock;
                    break;
                case 2:
                    compMove = Paper;
                    break;
                case 3:
                    compMove = Scissors;
                    break;
            }
            ComputerChoice.Text = compMove;
            
            if (compMove == Rock)
            {
                //ResultOfGame.ForeColor = Color.Chartreuse;
                ResultOfGame.Text = "You win this game!";
                yourPoints++;
                YourPointsCounter.Text = yourPoints.ToString();
            }
            else if (compMove == Paper)
            {
                //ResultOfGame.ForeColor = Color.Orange;
                ResultOfGame.Text = "This game was draw!"; 
            }
            else if (compMove == Scissors)
            {
                //ResultOfGame.ForeColor = Color.Red;
                ResultOfGame.Text = "You lose this game!";
                compPoints++;
                ComputerPointsCounter.Text = compPoints.ToString();
            }

            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
            RockButton.Enabled = false;
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            playerMove = Scissors;
            Random random = new Random();
            int compRandomNum = random.Next(1, 4);
            switch (compRandomNum)
            {
                case 1:
                    compMove = Rock;
                    break;
                case 2:
                    compMove = Paper;
                    break;
                case 3:
                    compMove = Scissors;
                    break;
            }
            ComputerChoice.Text = compMove;

            if (compMove == Rock)
            {
                //ResultOfGame.ForeColor = Color.Red;
                ResultOfGame.Text = "You lose this game!";
                compPoints++;
                ComputerPointsCounter.Text = compPoints.ToString();
            }
            else if (compMove == Paper)
            {
                //ResultOfGame.ForeColor = Color.Chartreuse;
                ResultOfGame.Text = "You win this game!";
                yourPoints++;
                YourPointsCounter.Text = yourPoints.ToString();
            }
            else if (compMove == Scissors)
            {
                //ResultOfGame.ForeColor = Color.Orange;
                ResultOfGame.Text = "This game was draw!";
            }
            ScissorsButton.Enabled = false;
            PaperButton.Enabled = false;
            RockButton.Enabled = false;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ScissorsButton.Enabled = true;
            PaperButton.Enabled = true;
            RockButton.Enabled = true;

            ResultOfGame.Text = String.Empty;
            ComputerChoice.Text = String.Empty;
            compMove = String.Empty;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
