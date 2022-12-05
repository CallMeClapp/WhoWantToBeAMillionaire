using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace FinalProject
{
    
    
    
    
    //Class Library for Core Game Classes, Player, Question, annd Abilities


    //Player
    public class Player
    {


        private int id;
        private string userName;
        private int abilityTier;
        private int abilitiesUsed;
        private int questionTier; //1 to 14

        public Player()
        {
            id = -1;
            userName = null;
            abilityTier = 0;
            abilitiesUsed = 0;
            questionTier = 0;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public int AbilityTier
        {
            get { return abilityTier; }
            set { abilityTier = value; }
        }

        public int AbilitiesUsed
        {
            get { return abilitiesUsed; }
            set { abilitiesUsed = value; }
        }

        public int QuestionTier
        {
            get { return questionTier; }
            set { questionTier = value; }
        }


        public void NewGame()
        {
            this.abilitiesUsed = 0;
            this.abilityTier = 0;
            this.questionTier = 0;
        }


    }



    //Question
    public class Question
    {

        private string answerOptionsA;
        private string answerOptionsB;
        private string answerOptionsC;
        private string answerOptionsD;
        private string correctAnswer; //0 = A, 1 = B, 2 = C, 3 = D
        private string questionString;
        private int questionKey; //1 to 15
        private int questionTier; //1 to 5
        


        public Question()
        {
            answerOptionsA = null;
            answerOptionsB = null;
            answerOptionsC = null;
            answerOptionsD = null;
            correctAnswer = null;
            questionString = null;
            questionKey = 1;
            questionTier = 1;
    }

        public string AnswerOptionA
        {
            get { return answerOptionsA; }
            set { answerOptionsA = value; }
        }
        public string AnswerOptionB
        {
            get { return answerOptionsB; }
            set { answerOptionsB = value; }
        }
        public string AnswerOptionC
        {
            get { return answerOptionsC; }
            set { answerOptionsC = value; }
        }
        public string AnswerOptionD
        {
            get { return answerOptionsD; }
            set { answerOptionsD = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string QuestionString
        {
            get { return questionString; }
            set { questionString = value; }
        }

        public int QuestionKey
        {
            get { return questionKey; }
            set { questionKey = value; }
        }
        public int QuestionTier
        {
            get { return questionTier; }
            set { questionTier = value; }
        }

        public int NextQuestionNumber ()
        {
            int temp = 1;
            //questionNum++;

            //foreach ( int in this.questionKey )
            //{

            if (this.questionKey == 1)
            {
                temp = 2;
            }
            if (this.questionKey == 2)
            {
                temp = 3;
            }
            if (this.questionKey == 3)
            {
                temp = 4;
            }
            if (this.questionKey == 4)
            {
                temp = 5;
            }
            if (this.questionKey == 5)
            {
                temp = 6;
            }
            if (this.questionKey == 6)
            {
                temp = 7;
            }

            if (this.questionKey == 7)
            {
                temp = 8;
            }
            if (this.questionKey == 8)
            {
                temp = 9;
            }
            if (this.questionKey == 9)
            {
                temp = 10;
            }
            if (this.questionKey == 10)
            {
                temp = 11;
            }
            if (this.questionKey == 11)
            {
                temp = 12;
            }
            if (this.questionKey == 12)
            {
                temp = 13;
            }
            if (this.questionKey == 13)
            {
                temp = 14;
            }
            if (this.questionKey == 14)
            {
                temp = 15;
            }
            if (this.questionKey == 15)
            {
                temp = 0;
            }
            //}
            return temp;
        }

        public Question NextQuestionFill (int temp)
        {
            Question tempQuestion = new Question();
            //int questionNumber = 0;
            //questionNumber = temp + 1;
                //this.NextQuestionNumber();

            tempQuestion = this.GetQuestion(temp);

            return tempQuestion;
        }

        // **to do**
        // add: pulls from DB
        public Question GetQuestion(int questionNum)
        {


            Question tempQuestion = new Question();
            //int tester = questionNum;

            //string strConnection = @"Provider = Microsoft.ACE.OLEDB.12.0;" + Data Source = C:\Users\alexc\source\repos\FinalProject\FinalProject\QuestionsDB.accdb";

            DataSet dataSet;
            OleDbConnection myOLEDBConnection;
            OleDbDataAdapter dataadapter;
            //@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\DanHG\***\QuestionsDB.accdb"
            //@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\alexc\source\repos\FinalProject\FinalProject\QuestionsDB.accdb"
            myOLEDBConnection = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\alexc\source\repos\FinalProject\FinalProject\QuestionsDB.accdb");
            myOLEDBConnection.Open();
            OleDbCommand cmd = myOLEDBConnection.CreateCommand();

            //questionNum = ;

            if (questionNum == 1)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 1";
            }
            if (questionNum == 2)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 2";
            }
            if (questionNum == 3)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 3";
            }
            if (questionNum == 4)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 4";
            }
            if (questionNum == 5)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 5";
            }
            if (questionNum == 6)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 6";
            }
            if (questionNum == 7)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 7";
            }
            if (questionNum == 8)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 8";
            }
            if (questionNum == 9)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 9";
            }
            if (questionNum == 10)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 10";
            }
            if (questionNum == 11)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 11";
            }
            if (questionNum == 12)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 12";
            }
            if (questionNum == 13)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 13";
            }
            if (questionNum == 14)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 14";
            }
            if (questionNum == 15)
            {
                cmd.CommandText = "SELECT * FROM QuestionsTable WHERE ID = 15";
            }
            //else
            //{
            //something broke with questionNum
            //    throw new Exception();
            //}


            //cmd.CommandText = "SELECT * FROM *";
            cmd.ExecuteNonQuery();
            dataSet = new DataSet();
            dataadapter = new OleDbDataAdapter(cmd);
            dataadapter.Fill(dataSet);

            DataRow drQuestion;
            drQuestion = dataSet.Tables[0].Rows[0];

            tempQuestion.questionString = drQuestion["Questions"].ToString();
            tempQuestion.answerOptionsA = drQuestion["A"].ToString();
            tempQuestion.answerOptionsB = drQuestion["B"].ToString();
            tempQuestion.answerOptionsC = drQuestion["C"].ToString();
            tempQuestion.answerOptionsD = drQuestion["D"].ToString();
            tempQuestion.correctAnswer = drQuestion["Answers"].ToString();

            myOLEDBConnection.Close();

            return tempQuestion;
        }



        //fix does not do as intended
        public bool CheckAnswer(string ABCD, Question question)
        {
            if ( ABCD == question.correctAnswer )
            {
                return true;

            }

            return false;
        }

    }




    //Abilites
    //Currently Empty
    public class Ability 
    {


        private int abilitySwitch;
        private int abilitySafetyNet;
        private int abilityJump;
        private int abilityRemoveWrong;


        public Ability()
        {
            // need to control how many abilites can be used
            // needs to control what abilites are unclocked
            // needs to store ability effects
            // 0 = alibty locked
            // 1 = ability unlocked and open to be used
            // 2 = ability locked and was used

            abilitySwitch = 0;
            abilitySafetyNet = 0;
            abilityJump = 0;
            abilityRemoveWrong = 0;

//Jump the Question(8 to 10); Skips the current question, the user will lose out on the value of that question
//Double Dip(5); Allows the user to retry the question, which must be done before the answer is submitted
//Switch the Question(3); Allows the user to swap the current with another in the same difficulty tier
//Remove Two Wrong Answers(11 to 13)


        }

        public int AbilitySwitch
        {
            get { return abilitySwitch; }
            set { abilitySwitch = value; }
        }
        public int AbilitySafetyNet
        {
            get { return abilitySafetyNet; }
            set { abilitySafetyNet = value; }
        }
        public int AbilityJump
        {
            get { return abilityJump; }
            set { abilityJump = value; }
        }
        public int AbilityRemoveWrong
        {
            get { return abilityRemoveWrong; }
            set { abilityRemoveWrong = value; }
        }
    }


}
