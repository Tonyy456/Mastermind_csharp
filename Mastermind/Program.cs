using System;
using System.IO;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Game Controller with prameters

            // ALLOW USER TO SELECT DIFFICULTY, length of password/# of guesses?
            //GameController controller = new GameController();
            //controller.start(settings);

            MastermindController controller = new MastermindController();
            controller.Start();
        }
    }
}
