using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{


    public class MastermindController
    {

        public MastermindController() { }

        public void SetCode(string code)
        {

        }

        public string EvaluateGuess(string guess)
        {

            return "";
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Mastermind!");
            PromptDifficulty();
        }

        private void PromptDifficulty()
        {
            Console.WriteLine("What difficulty do you want to play?\n (E)asy, (M)edium, (H)ard\n> ");
            string answer = Console.ReadLine();
            string cleaned_answer = answer.Trim().ToLower();
            
        }
    }
}
