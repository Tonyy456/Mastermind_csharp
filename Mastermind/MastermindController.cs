using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    /* Author: Anthony D'Alesandro
     * 
     * Enum for difficulty. Placed here so avoid excess files.
     */
    public enum Difficulty
    {
        Easy,
        Medium, 
        Hard
    }

    public class MastermindController
    {
        public Difficulty Difficulty { get; set; } = Difficulty.Easy;
        public MastermindController(Difficulty difficulty)
        {
            this.Difficulty = difficulty;
        }

        public void SetDifficulty(Difficulty difficulty)
        {
            Difficulty = difficulty;
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
