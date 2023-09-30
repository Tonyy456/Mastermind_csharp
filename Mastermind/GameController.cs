using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Mastermind
{
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
            controller = new MastermindController(sb.ToString());
        }

        public void Reset()
        {
            //allow multiple games to be played without re-running code.
        }
        public void Start()
        {
            PromptIntroduction();
            DisplayInstructions();
            Console.WriteLine($"Potential code characters: {allowedChars}");
            Console.WriteLine($"Secret code: {controller.Code}");

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

        public void Victory()
        {
            Console.WriteLine("You solved it!");
        }

        public void Defeat()
        {
            Console.WriteLine("You lose :(");
        }

        public void DisplayInstructions()
        {

        }

        public void PromptRules()
        {

        }

        public void PromptIntroduction()
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
