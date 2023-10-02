using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Mastermind
{
    /* Author: Anthony D'Alesandro
     * 
     * Controls main game flow. Enter through Start button.
     */
    public class GameController
    {
        //constants
        private readonly char[] allowedChars = { '1','2','3','4','5','6' };
        private const short maxGuesses = 12;
        private const short codeLength = 4;

        private MastermindController controller;
        private short numUserGuesses = 0;

        public GameController()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for(int i = 0; i < codeLength; i++)
            {
                sb.Append(allowedChars[random.Next(allowedChars.Length - 1)]);
            }
            controller = new MastermindController("3232");
        }

        /* Author: Anthony D'Alesandro
         * 
         * Controls main game flow. Enter through Start button.
         */
        public void Start()
        {
            PromptIntroduction();
            DisplayInstructions();
            while(numUserGuesses < maxGuesses)
            {
                Console.WriteLine("Enter your guess: ");
                string guess = Console.ReadLine();
                Console.WriteLine($"*Beep boop* heres your result: {controller.EvaluateGuess(guess)}");
                if (guess == controller.Code)
                {
                    Victory();
                    return;
                }
            }
            Defeat();
        }

        /* Author: Anthony D'Alesandro
         * 
         * Reset the game... template code that can be expanded off.
         */
        private void Reset()
        {
            //allow multiple games to be played without re-running code.
        }

        /* Author: Anthony D'Alesandro
         * 
         * Display victory message and actions
         */
        private void Victory()
        {
            Console.WriteLine("You solved it!");
        }

        /* Author: Anthony D'Alesandro
         * 
         * Display defeat message and actions
         */
        private void Defeat()
        {
            Console.WriteLine("You lose :(");
        }

        /* Author: Anthony D'Alesandro
         * 
         * Display instructions
         */
        private void DisplayInstructions()
        {
            Console.WriteLine($"Secret code: {controller.Code}");
            Console.WriteLine(
                $"Try to guess the #{codeLength} digit code that the program is thinking.\n" +
                $"It will return you a code and attempt to figure out the pattern behind it!\n" +
                $"You have #{numUserGuesses}\n" 
                );
        }

        /* Author: Anthony D'Alesandro
         * 
         * Display introduction
         */
        private void PromptIntroduction()
        {
            Console.WriteLine(
                " __          __  _                            _         \n" + 
                " \\ \\        / / | |                          | |        \n" +
                "  \\ \\  /\\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   \n" +
                "   \\ \\/  \\/ / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\  \n" +
                "    \\  /\\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | \n" +
                "  __ \\/_ \\/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/_ \n" +
                " |  \\/  |         | |                    (_)         | |\n" +
                " | \\  / | __ _ ___| |_ ___ _ __ _ __ ___  _ _ __   __| |\n" +
                " | |\\/| |/ _` / __| __/ _ \\ '__| '_ ` _ \\| | '_ \\ / _` |\n" +
                " | |  | | (_| \\__ \\ ||  __/ |  | | | | | | | | | | (_| |\n" +
                " |_|  |_|\\__,_|___/\\__\\___|_|  |_| |_| |_|_|_| |_|\\__,_|\n\n"
            );
        }
    }
}
