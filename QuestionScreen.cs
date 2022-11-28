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
    public partial class QuestionScreen : Form

    {

        Player player = new Player();
        Question questionC = new Question(); //Current Question
        Question questionN = new Question(); //Next Question
        Abilities abilities = new Abilities();
        int temp = 0;


        public QuestionScreen(Player player, Question questionC, Question questionN, Abilities ability)
        {
            InitializeComponent();
        }

        private void QuestionScreen_Load(object sender, EventArgs e)
        {
            //gets current question tier and itterates
            temp = questionC.NextQuestionTier(questionC.QuestionTier);
            questionN.QuestionTier = temp;


            //displays currnet question from database or list
            //***add list/DB first****
            //*not finished*
            questionC.NextQuestionFill(questionN.QuestionTier);
           
            //fill question Testbox
            this.rtxtQuestion.Text = questionN.QuestionString;


            //fill Answer Textboxes
            this.rtxtQuestion1.Text = questionN.AnswerOptionA;
            this.rtxtQuestion2.Text = questionN.AnswerOptionB;
            this.rtxtQuestion3.Text = questionN.AnswerOptionC;
            this.rtxtQuestion4.Text = questionN.AnswerOptionD;

            //resests questions
            questionC = questionN;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtxtQuestion4_TextChanged(object sender, EventArgs e)
        {

        }


        //A Button Choosen, Tests if Correct Answer 
        private void button1_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckA(0);
            tempbool = questionN.CheckAnswer(0, questionN);

            if (tempbool == true)
            {
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, abilities);
                nextQuestion.Show();
                this.Hide();
            } else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, abilities);
                newLoser.Show();
                this.Hide();
            }

        }

        //B Button Choosen, Tests if Correct Answer 
        private void button3_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckB(1);
            tempbool = questionN.CheckAnswer(1, questionN);

            if (tempbool == true)
            {
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, abilities);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser

                Loser newLoser = new Loser(player, questionN, abilities);
                newLoser.Show();
                this.Hide();


            }
        }

        //C Button Choosen, Tests if Correct Answer 
        private void button2_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckC(2);
            tempbool = questionN.CheckAnswer(2, questionN);

            if (tempbool == true)
            {
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, abilities);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, abilities);
                newLoser.Show();
                this.Hide();
            }
        }

        //D Button Choosen, Tests if Correct Answer 
        private void button4_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckD(3);
            tempbool = questionN.CheckAnswer(3, questionN);

            if (tempbool == true)
            {
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, abilities);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, abilities);
                newLoser.Show();
                this.Hide();
            }
        }


        //Opens LifeLine Form
        private void btnLifeLine_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void rtxtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
