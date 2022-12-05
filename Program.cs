using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Player player = new Player();
            Question questionC = new Question(); //Current Question
            Question questionN = new Question(); //Next Question
            Ability ability = new Ability();

            Application.Run(new MainMenu(player, questionC, ability));
        }
    }
}
