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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bensinen börjar tar slut");
                Console.ResetColor();
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

        }

       
        public void DriverFatigue(STATS stats)
        {
            stats.Fatigue++;
            Console.WriteLine("Förarens trötthet har ökat");

            if (stats.Fatigue >= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Föraren är mycket trött! Du Måste ta en rast snart.");
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
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Bilen har tankats till full kapacitet");
            Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bensinen börjar tar slut");
                Console.ResetColor();
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
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bensinen börjar tar slut");
                Console.ResetColor();
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
            
        }
       
        public void Rest(STATS stats)
        {
            stats.Fatigue = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Föraren tog en rast");
            Console.ResetColor();
           
        }
        public void Exit()
        {
            // Logik för att starta motorn
            Environment.Exit(0);
        }
    }
}
