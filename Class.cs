using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhosAMillion
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
        private int correctAnswer; //0 = A, 1 = B, 2 = C, 3 = D
        private string questionString;
        private int questionKey;
        private int questionTier; //1 to 14


        public Question()
        {
            answerOptionsA = null;
            answerOptionsB = null;
            answerOptionsC = null;
            answerOptionsD = null;
            correctAnswer = -1;
            questionString = null;
            questionKey = -1;
            questionTier = -1;
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

        public int CorrectAnswer
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

        public int NextQuestionTier (int questionNum)
        {
            //questionNum++;
            return questionNum++;
        }

        public Question NextQuestionFill (int questionTier)
        {
            Question tempQuestion = new Question();
            tempQuestion = this.GetQuestion(questionTier);
            return tempQuestion;
        }

        // **to do**
        // add :pulls from DB or String List
        public Question GetQuestion(int questionNum)
        {
            Question tempQuestion = new Question();
            int tester = questionNum;
            
            if (tester == 1) { tempQuestion = GetQ1(); }
            if (tester == 2) { tempQuestion = GetQ2(); }
            if (tester == 3) { tempQuestion = GetQ3(); }
            if (tester == 4) { tempQuestion = GetQ4(); }
            if (tester == 5) { tempQuestion = GetQ5(); }
            if (tester == 6) { tempQuestion = GetQ6(); }
            if (tester == 7) { tempQuestion = GetQ7(); }
            if (tester == 8) { tempQuestion = GetQ8(); }
            if (tester == 9) { tempQuestion = GetQ9(); }
            if (tester == 10) { tempQuestion = GetQ10(); }
            if (tester == 11) { tempQuestion = GetQ11(); }
            if (tester == 12) { tempQuestion = GetQ12(); }
            if (tester == 13) { tempQuestion = GetQ13(); }
            if (tester == 14) { tempQuestion = GetQ14(); }

            return tempQuestion;
        }

        //***to do*** 
        //
        // add database for these to pull from 
        // (!or!) 
        // add a list of strings for each
        // question tier to pull from 
        public Question GetQ1() {
            Question tempQuestion = new Question();
            return tempQuestion; }
        public Question GetQ2() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ3() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ4() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ5() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ6() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ7() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ8() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ9() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ10() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ11() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ12() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ13() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }
        public Question GetQ14() {
            Question tempQuestion = new Question();
            return tempQuestion;
        }



        public bool CheckAnswer(int Num, Question question)
        {
            if (Num == 1 && question.CorrectAnswer == 1) {
                return true;
                    }
            if (Num == 2 && question.CorrectAnswer == 2)
            {
                return true;
            }
            if (Num == 3 && question.CorrectAnswer == 3)
            {
                return true;
            }
            if (Num == 4 && question.CorrectAnswer == 4)
            {
                return true;
            }
            if (Num == 5 && question.CorrectAnswer == 5)
            {
                return true;
            }
            if (Num == 6 && question.CorrectAnswer == 6)
            {
                return true;
            }
            if (Num == 7 && question.CorrectAnswer == 7)
            {
                return true;
            }
            if (Num == 8 && question.CorrectAnswer == 8)
            {
                return true;
            }
            if (Num == 9 && question.CorrectAnswer == 9)
            {
                return true;
            }
            if (Num == 10 && question.CorrectAnswer == 10)
            {
                return true;
            }
            if (Num == 11 && question.CorrectAnswer == 11)
            {
                return true;
            }
            if (Num == 12 && question.CorrectAnswer == 12)
            {
                return true;
            }
            if (Num == 13 && question.CorrectAnswer == 13)
            {
                return true;
            }
            if (Num == 14 && question.CorrectAnswer == 14)
            {
                return true;
            }

            //return true;
            return false;
        }

    }




    //Abilites
    //Currently Empty
    public class Abilities { }


}
