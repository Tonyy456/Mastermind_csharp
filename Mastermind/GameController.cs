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


    public class GameController
    {
        public Difficulty Difficulty { get; set; } = Difficulty.Easy;
        public GameController(Difficulty difficulty)
        {

        }
        public void SetDifficulty(Difficulty difficulty)
        {
            Difficulty = difficulty;
        }
    }
}
