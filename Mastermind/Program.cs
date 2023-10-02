using System;
using System.IO;

namespace Mastermind
{
    /* Author: Anthony D'Alesandro
     * 
     * Main method for mastermind
     */
    class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.Start();
        }
    }
}
