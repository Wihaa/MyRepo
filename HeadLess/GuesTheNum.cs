using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLess
{
    public class GuesTheNum
    {
        public string PlayTheGame(int betweenThis, int andThis) {

            bool isTheGuessWasOk;
            int numnerOfGuesses = 1;
            int theGuessWhatYouGave;
            string endOfTheGame = "";

            Random rnd = new Random();
            int whatShouldBeFind = rnd.Next(betweenThis, andThis);

            do
            {
                Console.WriteLine("Make the {0}. guess", numnerOfGuesses);
                theGuessWhatYouGave = Int16.Parse(Console.ReadLine());

                if (theGuessWhatYouGave != whatShouldBeFind)
                {
                    isTheGuessWasOk = false;
                    numnerOfGuesses++;
                    Console.WriteLine("Lets give it another try");
                }
                else
                {
                    isTheGuessWasOk = true;
                    endOfTheGame = "Hey you find the correct number with" + numnerOfGuesses;
                }
            } while (isTheGuessWasOk == false);

            return endOfTheGame;
        }

    }
}
