using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDemoBam4a19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* in C# zijn er verschillende soorten loops (herhalingsconstructies, een ander woord voor 
             * herhaling is iteratie) met elk hun eigen toepassingen
             * het is belangrijk dat je weet wanneer je welke loop het beste kunt gebruiken
             * 
             * we onderscheiden:
             * de for loop
             * de while loop
             * de do while loop
             * de for each loop
             *  
             * verder zijn er de statemens break en continue:
             * 
             * break zorgt ervoor dat de loop direct verlaten wordt
             *   (handig als je bvb. in een lijst het gezochte item hebt gevonden,
             *   het heeft dan geen zin meer om verder te zoeken)
             *  
             * continue zorgt ervoor dat de rest van de loop niet uitgevoerd wordt
             * maar dat de loop direct opnieuw begint (handig als je bvb. binnen een loop
             * er eentje wilt overslaan)
             *              * 
             * tot slot: loops kun je nesten, d.w.z. je kunt een loop in een loop (in een loop etc...) hebben
             * maar kan ten koste gaan van de performance van je programma
             * 
             * en er bestaan oneindige loops
             * 
             * hieronder vind je voorbeelden, bestudeer de code en test de werking
             */

            int i; // telvariabele


            // de for loop (deze gebruik je als je vooraf al weet hoe vaak iets herhaald moet worden)

            Console.WriteLine("BEGIN FOR LOOP -----------------------------");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("END OF FOR LOOP -----------------------------"); 


            // de while looop (deze gebruik je als je niet weet hoe vaak iets herhaald moet worden, 
            // bvb. je vraagt rijen uit een database op met een query )
            i = 1;
            int aantalrijen = 13; // willekeurig getal
            Console.WriteLine("BEGIN OF WHILE LOOP -------------------------");
            while (i <= aantalrijen)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("END OF WHILE LOOP ---------------------------");


            // do while (als je wil dat de loop ten minste 1 keer wordt uitgevoerd)
            i = 1;
            Console.WriteLine("BEGIN OF DO WHILE LOOP ----------------------");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10); // de controle zit aan het einde van de loop dus hij gaat er altijd 1 keer doorheen
            Console.WriteLine("END OF DO WHILE LOOP ------------------------");


            // foreach (als je door een array of lijst gaat)
            string[] pets = { "dog", "cat", "bird", "bunny", "donkey" };
            Console.WriteLine("BEGIN OF DO FOREACH LOOP --------------------");
            foreach (string pet in pets)
            {
                Console.WriteLine(pet); // pet is het huidige element van het array
            }
            Console.WriteLine("END OF DO FOREACH LOOP ----------------------");


            // break, stopt de loop direct
            int a = 0;
            Console.WriteLine("BEGIN OF BREAK EXAMPLE ----------------------");
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
                if (a > 15)
                {
                    /* terminate the loop using break statement */
                    break;
                }
            }
            Console.WriteLine("END OF BREAK EXAMPLE ------------------------");

            // continue, begint opnieuw met de loop
            Console.WriteLine("BEGIN OF CONTINUE EXAMPLE -------------------");
            do
            {
                if (a == 15)
                {
                    /* skip the iteration */
                    a++;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
            Console.WriteLine("END OF CONTINUE EXAMPLE ---------------------");

            // geneste loop
            int total = 0;
            Console.WriteLine("BEGIN OF NESTED LOOP EXAMPLE ----------------");
            for (i = 1; i <= 100; i++) // i was boven al gedeclareerd
            {
                for (int j = 1; j <= 100; j++)
                {
                    for (int k = 1; k <= 100; k++)
                    {
                        // Console.WriteLine("i: {0}, j: {0}, k: {0}", i, j, k);
                        total++; // wat wordt de waarde van i?
                    }
                }
            }
            Console.WriteLine("total: {0}", total);
            Console.WriteLine("END OF NESTED LOOP EXAMPLE ------------------");



            // oneindige loop
            /*
            Console.WriteLine("BEGIN OF INFINITE LOOP EXAMPLE --------------");
            i = 0;
            while (i < 10)
            {
                Console.Write("i: {0} ", i);
                // de waarde van i verandert niet, dus i zal altijd < 10 blijven, dus de loop zal nooit stoppen
            }
            Console.WriteLine("END OF INFINITE LOOP EXAMPLE --------------");
            */

            Console.ReadLine();
        }
    }
}
