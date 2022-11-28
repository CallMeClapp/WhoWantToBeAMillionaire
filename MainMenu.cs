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
    public partial class MainMenu : Form
    {

        Player player = new Player();
        Question questionN = new Question();
        Question questionC = new Question();
        Abilities abilities = new Abilities();

        public MainMenu(Player player, Question question, Abilities ability)
        {
            InitializeComponent();
        }

        
        //"Start New Game" Button, Will Start New Player Class & Gets New Questions
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            questionC.QuestionTier = 1;
            QuestionScreen newGame = new QuestionScreen( player,  questionC,  questionN, abilities);
            newGame.Show();
            this.Hide();
        }


        // Opens LifeLine Page 
        private void btnDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
