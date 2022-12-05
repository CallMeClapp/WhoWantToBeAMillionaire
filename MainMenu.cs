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
    public partial class MainMenu : Form
    {

        Player player = new Player();
        Question questionN = new Question();
        Question questionC = new Question();
        Ability ability = new Ability();

        public MainMenu(Player player, Question question, Ability ability)
        {
            InitializeComponent();
        }


        //Main Menu to Player Stats
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //New Game Button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //questionC.QuestionTier = 1;
            int questionCount = 1; 
            QuestionScreen newGame = new QuestionScreen(player, questionC, questionN, ability, questionCount);
            newGame.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
