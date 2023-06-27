using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CarSimulator
    {
        //public int driverFatigue = 0;
        //public Direction carDirection;
        //public int gasolineLevel = 50;
        //public const int MaxDriverFatigue = 10;
        //public const int WarningThreshold = 4;
        public void SetDirection(Direction direction, STATS stats)
        {
            stats.Direction = direction;
            Console.WriteLine($"Bilens riktning har satts till {direction}");
            if (stats.Fuel <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bensinen är slut. Du måste tanka innan du kan köra vidare.");
                Console.ResetColor();
            }
            else if (stats.Fuel < 10)
            {
                Console.WriteLine("Bensinen börjar tar slut");
                Console.WriteLine("Bilen kör framåt");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }
            else
            {
                Console.WriteLine("bilen kör framåt");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }

            //stats.Fatigue++;
            //Console.WriteLine("Förarens trötthet har ökat");

            //if (stats.Fatigue == MaxDriverFatigue)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Föraren är mycket trött! Du bör ta en rast snart.+ {CarStatus.FatigueLevelTooLow}");
            //    Console.ResetColor();
            //}
            //else if (stats.Fatigue >= 7 && stats.Fatigue <= 9 )
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Föraren börjar bli trött. Du bör snart ta en rast.+ {CarStatus.FatigueLevelLow}");
            //    Console.ResetColor();
            //}
        }

        //public void SelectMenuOption(MenuOption option)
        //{
        //    Console.WriteLine($"Menyoption {option} har valts");

        //}

        public void DriverFatigue(STATS stats)
        {
            stats.Fatigue++;
            Console.WriteLine("Förarens trötthet har ökat");

            if (stats.Fatigue >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Föraren är mycket trött! Du bör ta en rast snart.");
                Console.ResetColor();
            }
            else if (stats.Fatigue >= 7 && stats.Fatigue <= 9)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Föraren börjar bli trött. Du bör snart ta en rast.");
                Console.ResetColor();
            }

        }

        public void RefuelGasoline(STATS stats)
        {
            // Logik för att fylla på bensin
            stats.Fuel = 30;
            Console.WriteLine("Bilen har tankats till full kapacitet");
        }

        public void DriveForward(STATS stats)
        {
            // Logik för att starta motorn
            if (stats.Fuel <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bensinen är slut. Du måste tanka innan du kan köra vidare.");
                Console.ResetColor();
            }
            else if (stats.Fuel < 10)
            {
                Console.WriteLine("Bensinen börjar tar slut");
                // Console.WriteLine("Bilen backar");
                Console.WriteLine("Bilen kör framåt");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }
            else
            {
                Console.WriteLine("bilen kör framåt");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }

            //stats.Fatigue++;
            //Console.WriteLine("Förarens trötthet har ökat");

            //if (stats.Fatigue == MaxDriverFatigue)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Föraren är mycket trött! Du bör ta en rast snart.+ {CarStatus.FatigueLevelTooLow}");
            //    Console.ResetColor();
            //}
            //else if (stats.Fatigue >= 7 && stats.Fatigue <= 9)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Föraren börjar bli trött. Du bör snart ta en rast.+ {CarStatus.FatigueLevelLow}");
            //    Console.ResetColor();
            //}
        }
        public void Reverse(STATS stats)
        {
            // Logik för att starta motorn
            if (stats.Fuel == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bensinen är slut. Du måste tanka innan du kan köra vidare.");
                Console.ResetColor();
            }
            else if (stats.Fuel < 10 )
            {
                Console.WriteLine("Bensinen börjar tar slut");
                Console.WriteLine("Bilen backar");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }
            else
            {
                Console.WriteLine("bilen backar");
                stats.Fatigue++;
                stats.Fuel -= 3;
            }
            //stats.Fatigue++;
            //Console.WriteLine("Förarens trötthet har ökat");

            //if (stats.Fatigue <= 1)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Föraren är mycket trött! Du bör ta en rast snart.+ {CarStatus.FatigueLevelTooLow}");
            //    Console.ResetColor();
            //}
            //else if (stats.Fatigue >= 4 && stats.Fatigue <= 6)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine($"Föraren börjar bli trött. Du bör snart ta en rast.+ {CarStatus.FatigueLevelLow}");
            //    Console.ResetColor();
            //}
        }
        //public void Rest()
        //{
        //    // Logik för att starta motorn
        //    Console.WriteLine("Bilen bromsar");
        //    driverFatigue++;
        //}
        public void Rest(STATS stats)
        {
            stats.Fatigue = 0;
            Console.WriteLine("Föraren tog en rast");
            //if (stats.Fatigue == 10)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Föraren är för trött! Du måste ta en rast.");
            //    Console.WriteLine("Bilen stannar tills du tar en rast.");
            //    Console.ResetColor();

            //    while (stats.Fatigue <= 10)
            //    {
            //        // Vänta på att föraren tar en rast
            //        Console.WriteLine("Väntar på att du tar en rast...");
            //        // Här kan du lägga till eventuell kod för att vänta, t.ex. Thread.Sleep() eller liknande
            //    }

            //    Console.WriteLine("Du har tagit en rast. Du kan fortsätta köra nu.");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Föraren är inte tillräckligt trött för att ta en rast.");
            //    Console.ResetColor();
            //}
        }
        public void Exit()
        {
            // Logik för att starta motorn
            Environment.Exit(0);
        }
    }
}
