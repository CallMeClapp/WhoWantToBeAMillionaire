using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhosAMillion
{
    public partial class Loser : Form
    {
        Player player = new Player();
        Question questionN = new Question();
        Question questionC = new Question();
        Abilities abilities = new Abilities();

        public Loser(Player player, Question question, Abilities ability)
        {
            InitializeComponent();
        }

        //Start New Game from Q1
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //this.Player.NewGame()

            questionC.QuestionTier = 0;
            QuestionScreen newGame = new QuestionScreen(player, questionC, questionN, abilities);
            newGame.Show();
            this.Hide();
        }
    }
}
