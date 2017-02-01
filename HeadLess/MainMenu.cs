using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadLess
{
    public class MainMenu
    {
        public void MainMenuControll(int choosenSubmenu)
        {

            bool isThatMenu = true;

            while (isThatMenu)
            {

                if (choosenSubmenu == 2)
                {
                    Console.WriteLine("give a positive intervall in which you want to make a guess");
                    Console.WriteLine("from:");
                    int fromvalueinintervall = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("to:");
                    int tovalueinintervall = Int32.Parse(Console.ReadLine());

                    var a = new GuesTheNum();
                    a.PlayTheGame(fromvalueinintervall,tovalueinintervall);
                    Console.WriteLine(a);

                }
            }
        }
    }
}
