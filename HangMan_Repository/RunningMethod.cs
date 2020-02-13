using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Repository
{
    public class RunningMethod
    {
        GameRepository _game = new GameRepository();


        public void Run()

        {
            RunMenu();

        }

        private void RunMenu()
        {
            _game.GuessChance = 7;
            _game.IsDiscovered = false;
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(".----------------.  .----------------.  .---------------- -. .----------------.  .----------------.  .----------------.  .-----------------.\n" +
                    "| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. | \n" +
                    "| |  ____  ____  | || |      __      | || | ____  _____  | || |    ______    | || | ____    ____ | || |      __      | || | ____  _____  | | \n" +
                    "| | |_   ||   _| | || |     /  \\     | || ||_   \\|_   _| | || |  .' ___  |   | || ||_   \\  /   _|| || |     /  \\     | || ||_   \\|_   _| | | \n" +
                    "| |   | |__| |   | || |    / /\\ \\    | || |  |   \\ | |   | || | / .'   \\_|   | || |  |   \\/   |  | || |    / /\\ \\    | || |  |   \\ | |   | | \n" +
                    "| |   |  __  |   | || |   / ____ \\   | || |  | |\\ \\| |   | || | | |    ____  | || |  | |\\  /| |  | || |   / ____ \\   | || |  | |\\ \\| |   | | \n" +
                    "| |  _| |  | |_  | || | _/ /    \\ \\_ | || | _| |_\\   |_  | || | \\ `.___]  _| | || | _| |_\\/_| |_ | || | _/ /    \\ \\_ | || | _| |_\\   |_  | | \n" +
                    "| | |____||____| | || ||____|  |____|| || ||_____|\\____| | || |  `._____.'   | || ||_____||_____|| || ||____|  |____|| || ||_____|\\____| | | \n" +
                    "| |              | || |              | || |              | || |              | || |              | || |              | || |              | | \n" +
                    "| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' | \n" +
                    "'----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' \n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "                                                                                   + ---+\n" +
                    "                                                                                   |    |\n" +
                    "                                                                                        |\n" +
                    "                                                      0                                 |\n" +
                    "                                                     /|\\                                |\n" +
                    "                                                     / \\                                |\n" +
                    "                                               ===================================================''',"

                    
                    
                    );

                                 



                Console.WriteLine("Welcome To Hangman \n" +
                    "1. Play New Game\n" +
                    "2. Exit");

                char userInput = Console.ReadLine()[0];
                Console.Clear();
                switch (userInput)
                {

                    case '1':

                        _game.HostInputWord();
                        Console.Clear();

                        bool isRunning = true;
                        while (isRunning == true)
                        {
                            string userWord = string.Join("", _game.GuessWord);
                            Console.WriteLine($"The word you wrote is: {userWord}. Is this correct?\n" +
                                $"Press 1 for yes. Hit any other key for no.");
                            string rightWord = Console.ReadLine();
                            switch (rightWord)
                            {
                                case "1":
                                    isRunning = false;
                                    break;
                                default:
                                    _game.GuessWord = new List<char>();
                                    _game.HostInputWord();
                                    _game.WordProgress = new List<char>();
                                    Console.Clear();
                                    break;
                            }

                        }
                        Console.Clear();
                        string correctWord = string.Join("", _game.GuessWord);

                        Console.WriteLine("Player 2 Begin");
                        Console.WriteLine($"The word is {_game.GuessWord.Count} letter(s) long");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();

                        _game.WriteWordProgress();
                        _game.CheckStringForUnderscore();

                        while (_game.GuessChance > 0 && _game.CheckStringForUnderscore() == true)
                        {

                            if (_game.GuessChance == 7)
                            {

                                Console.WriteLine($" +---+\n" +
                                    " |   |\n" +
                                    "     |\n" +
                                    "     |\n" +
                                    "     |\n" +
                                    "     |\n" +
                                    "=========''',");
                            }
                            else if (_game.GuessChance == 6)
                            {
                                Console.WriteLine($" +---+\n" +
                                      " |   |\n" +
                                      " 0   |\n" +
                                      "     |\n" +
                                      "     |\n" +
                                      "     |\n" +
                                      "=========''',");
                            }
                            else if (_game.GuessChance == 5)
                            {
                                Console.WriteLine($" +---+\n" +
                                      " |   |\n" +
                                      " 0   |\n" +
                                      " |   |\n" +
                                      "     |\n" +
                                      "     |\n" +
                                      "=========''',");
                            }
                            else if (_game.GuessChance == 4)
                            {
                                Console.WriteLine($" +---+\n" +
                                       " |   |\n" +
                                       " 0   |\n" +
                                       "/|   |\n" +
                                       "     |\n" +
                                       "     |\n" +
                                       "=========''',");
                            }
                            else if (_game.GuessChance == 3)
                            {
                                Console.WriteLine($" +---+\n" +
                                 " |   |\n" +
                                 " 0   |\n" +
                                 "/|\\  |\n" +
                                 "     |\n" +
                                 "     |\n" +
                                 "=========''',");
                            }
                            else if (_game.GuessChance == 2)
                            {
                                Console.WriteLine($" +---+\n" +
                                " |   |\n" +
                                " 0   |\n" +
                                "/|\\  |\n" +
                                "/    |\n" +
                                "     |\n" +
                                "=========''',");
                            }
                            else if (_game.GuessChance == 1)
                            {
                                Console.WriteLine($" +---+\n" +
                                    " |   |\n" +
                                    " 0   |\n" +
                                    "/|\\  |\n" +
                                    "/ \\  |\n" +
                                    "     |\n" +
                                    "=========''',");
                            }
                          





                            _game.PlayerTitleCard();

                            string listAsString = string.Join("  ", _game.WordProgress);
                            Console.WriteLine($"{listAsString}");
                            Console.WriteLine("\n");
                            string junkList = string.Join(", ", _game.JunkLetter);
                            Console.WriteLine($"Junk Letters \n" +
                                $"{junkList}");

                            _game.PlayerTwoInput_Check();

                            _game.CheckStringForUnderscore();
                        }

                        if (_game.GuessChance == 0)
                        {

                            Console.WriteLine($" +---+\n" +
                                " |   |\n" +
                                " |   |\n" +
                                "0|   |\n" +
                                "/|\\  |\n" +
                                "/ \\  |\n" +
                                "     |\n" +
                                "=========''',");




                            Console.WriteLine($"You lose. The word was {correctWord}\n" +
                                $"Big Shocker....Try again loser.");
                            Console.ReadLine();

                        }

                        else
                        {
                            Console.WriteLine($"  +---+\n" +
                               "  |   |\n" +
                               "      |\n" +

                               " \\0/  |\n" +
                               "  |   |\n" +
                               " / \\  |\n" +
                               "=========''',");



                            Console.WriteLine("Congratulations you are a good guesser. I guess.\n" +
                                "Guess again?");
                            Console.ReadLine();
                        }
                        _game.GuessWord = new List<char>();
                        _game.WordProgress = new List<char>();
                        _game.GuessChance = 7;
                        break;

                    case '2':
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please selecet 1 or 2.");
                        Console.ReadKey();
                        continueToRun = true;
                        break;

                }
            }
        }
    }
}
