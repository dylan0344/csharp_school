using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramides_functies
{
    class Program
    {
        static void PrintLinksuitgelijndePiramide(int diepte, char symbool='*')
        {
            for (int i = 1; i <= diepte; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(symbool);
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintLinksuitgelijndePiramide(5);
            PrintLinksuitgelijndePiramide(10, '+');

            /* TO DO:
            maak de volgende functies
            1. PrintRechtsuitgelijndePiramide(5);
            uitvoer:
                *
               **
              ***
             ****
            *****
            
            en
            2. PrintGecentreerdePiramide(5);
            uitvoer:
                *
               ***
              *****
             *******
            *********
            

            */

            Console.ReadLine();
        }
    }
}
