using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLess
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Hey Dude");
            Console.WriteLine("It is the HeadLess game!");
            Console.WriteLine("Let's the game begin!");

            Console.WriteLine("Coose one from the followig Menu");
            Console.WriteLine("1) Headless");
            Console.WriteLine("2) Bonus game: GessTheNum");
            Console.WriteLine("Exit");

            int choosenSubmenu = Int32.Parse(Console.ReadLine());

            var b = new MainMenu();
            b.MainMenuControll(choosenSubmenu);           
        }
    }
}
