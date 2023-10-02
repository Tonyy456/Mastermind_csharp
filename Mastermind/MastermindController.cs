using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{

    /* Author: Anthony D'Alesandro
     * 
     * Controls mastermind code logic.
     */
    public class MastermindController
    {
        /* Author: Anthony D'Alesandro
         * 
         * requires: @code{code} to have at least one non white space character.
         */
        private string code;
        public string Code { 
            get
            {
                return this.code;
            }
            set
            {
                this.code = value.Trim();

                // add more requirements of the Mastermind code here...
                if(this.code.Length == 0)
                {
                    throw new System.Exception("Must have a code of at least 1 non white space");
                }
            }
        }

        /* Author: Anthony D'Alesandro
         * 
         * Simply for code readability and accessibility.
         */
        public int CodeLength { 
            get { 
                return Code.Length;
            }
        }


        public MastermindController(string code) 
        {
            this.Code = code.Trim();
        }

        /* Author: Anthony D'Alesandro
         * 
         * Evaluate guess vs this.Code in the following manner:
         * 
         * - prepend '+' for every matched character in the correct position.
         * - append '-' for every character that is shared between strings but not in the right position.
         */
        public string EvaluateGuess(string guess)
        {
            StringBuilder evaluation = new StringBuilder();
            List<char> matchable = new List<char>(Code.ToCharArray());
            for (int i = 0; i < CodeLength && i < guess.Length; i++)
            {
                char g = guess[i];
                if (Code[i] == g)
                {
                    evaluation.Insert(0, '+');
                    matchable.Remove(g);
                } else if (matchable.Contains(g))
                {
                    evaluation.Append('-');
                    matchable.Remove(g);
                }
            }
            return evaluation.ToString();
        }
    }
}
