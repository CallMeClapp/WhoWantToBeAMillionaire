using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Loser : Form
    {
        Player player = new Player();
        Question questionN = new Question();
        Question questionC = new Question();
        Ability ability = new Ability();
        int count = 1;

        public Loser(Player player, Question question, Ability ability)
        {
            InitializeComponent();
        }

        //Start New Game from Q1
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //this.Player.NewGame()

            questionC.QuestionTier = 0;
            QuestionScreen newGame = new QuestionScreen(player, questionC, questionN, ability, count);
            newGame.Show();
            this.Hide();
        }


        //Start New Game
        private void btnPlayAgain_Click_1(object sender, EventArgs e)
        {
            questionC.QuestionTier = 0;
            QuestionScreen newGame = new QuestionScreen(player, questionC, questionN, ability, count);
            newGame.Show();
            this.Hide();
        }
    }
}
