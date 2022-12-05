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
    public partial class QuestionScreen : Form
    {

        Player player = new Player();
        Question questionC = new Question(); //Current Question
        Question questionN = new Question(); //Next Question
        Ability ability = new Ability();
        int count = 0;
        Question tempQuestion = new Question();


        public QuestionScreen(Player player, Question questionCurrent, Question questionNext, Ability ability, int questionCount)
        {
            questionC = questionCurrent;
            questionN = questionNext;
            count = questionCount;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void btnLifeLine_Click(object sender, EventArgs e)
        {

        }

        private void QuestionScreen_Load(object sender, EventArgs e)
        {
            //gets current question number and itterates
            //temp = questionC.NextQuestionNumber(questionC.QuestionTier);
            //questionN.QuestionTier = temp;


            //displays currnet question from database or list
                //***add list/DB first****
                //*not finished*
                //fills "next" question
            questionN = questionC.NextQuestionFill(count);


                //fills question Testbox
            this.rtxtQuestion.Text = questionN.QuestionString;

            //fills Answer Textboxes
            this.rtxtQuestion1.Text = questionN.AnswerOptionA;
            this.rtxtQuestion2.Text = questionN.AnswerOptionB;
            this.rtxtQuestion3.Text = questionN.AnswerOptionC;
            this.rtxtQuestion4.Text = questionN.AnswerOptionD;

                //progress questions
            questionC = questionN;
            //temp++;
        }

        //A Button
        private void button1_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckA(0);
            tempbool = questionC.CheckAnswer("A", questionC);

            if (tempbool == true)
            {
                //temp++;
                count++;
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, ability, count);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, ability);
                newLoser.Show();
                this.Hide();
            }

        }

        //B Button
        private void button2_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckB(1);
            tempbool = questionC.CheckAnswer("B", questionC);

            if (tempbool == true)
            {
                //temp++;
                count++;
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, ability, count);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser

                Loser newLoser = new Loser(player, questionN, ability);
                newLoser.Show();
                this.Hide();

            }
        }

        //C Button
        private void button4_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckC(2);
            tempbool = questionC.CheckAnswer("C", questionC);

            if (tempbool == true)
            {
                //temp++;
                count++;
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, ability, count);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, ability);
                newLoser.Show();
                this.Hide();
            }
        }

        //D Button
        private void button3_Click(object sender, EventArgs e)
        {
            bool tempbool = false;
            //CheckD(3);
            tempbool = questionC.CheckAnswer("D", questionC);

            if (tempbool == true)
            {
                //temp++;
                count++;
                //load next question
                QuestionScreen nextQuestion = new QuestionScreen(player, questionC, questionN, ability, count);
                nextQuestion.Show();
                this.Hide();
            }
            else
            {
                //load loser
                Loser newLoser = new Loser(player, questionN, ability);
                newLoser.Show();
                this.Hide();
            }
        }

        private void rtxtQuestion2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
