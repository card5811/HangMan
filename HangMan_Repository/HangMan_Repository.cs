using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Repository
{
    public class GameRepository
    {
        public List<char> GuessWord = new List<char>();
        public List<char> WordProgress = new List<char>();
        public List<char> JunkLetter = new List<char>();



        public bool IsDiscovered = false;
        public int GuessChance = 7;

        public void HostInputWord()
        {

            //Should let host put word into game turn to list of characters.
            Console.WriteLine("Please enter word");
            string hostInput = Console.ReadLine();
            hostInput = hostInput.ToLower();
            Console.Clear();

            Char[] charArr = hostInput.ToCharArray();

            foreach (char letter in charArr)
            {
                IsDiscovered = false;
                GuessWord.Add(letter);
            }


        }

        public void PlayerTitleCard()
        {

            Console.WriteLine($"You have {GuessChance} chances left.");

        }

        public void WriteWordProgress()
        {
            foreach (char letter in GuessWord)
            {
                if (IsDiscovered == false)
                {
                    WordProgress.Add('_');
                }

                else

                    WordProgress.Add(letter);
            }
            string listAsString = GuessWord.ToString();



        }

        public void PlayerTwoInput_Check()
        {



            string playerTwoInput = Console.ReadLine();
            playerTwoInput = playerTwoInput.ToLower();
            char TwoInput = playerTwoInput[0];


            if (GuessWord.Contains(TwoInput))
            {
                IsDiscovered = true;
                do
                {
                    int letterIndex = GuessWord.IndexOf(TwoInput);
                    WordProgress.RemoveAt(letterIndex);
                    WordProgress.Insert(letterIndex, TwoInput);
                    GuessWord.RemoveAt(letterIndex);
                    GuessWord.Insert(letterIndex, '_');

                }
                while (GuessWord.Contains(TwoInput));
                Console.Clear();
            }
            else
            {
                GuessChance = GuessChance -= 1;
                JunkLetter.Add(TwoInput);
                Console.WriteLine($"Try again.");
                Console.Clear();
            }


        }

        public bool CheckStringForUnderscore()
        {
            string listAsString = string.Join("", WordProgress);
            bool containsUnderscore = listAsString.Contains('_');
            return containsUnderscore;
        }
    }
}



