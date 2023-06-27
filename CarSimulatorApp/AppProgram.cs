//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CarSimulatorApp
//{

//    public static void Main(string[] args)
//    {
//        CarSimulator carSimulator = new CarSimulator();

//        while (true)
//        {
//            Console.WriteLine("Välj en kommando:");
//            Console.WriteLine("1. DriveForward");
//            Console.WriteLine("2. Reverse");
//            Console.WriteLine("3. Rest");
//            Console.WriteLine("4. Exit");
//            Console.WriteLine("5. Sätt riktning");
//            Console.WriteLine("6. Välj menyoption");
//            Console.WriteLine("7. Öka trötthet");
//            Console.WriteLine("8. Fyll på bensin");
//            Console.WriteLine("9. Avsluta");

//            string input = Console.ReadLine();

//            switch (input)
//            {
//                case "1":
//                    carSimulator.DriveForward();
//                    break;
//                case "2":
//                    carSimulator.Reverse();
//                    break;
//                case "3":
//                    carSimulator.Rest();
//                    break;
//                case "4":
//                    carSimulator.Exit();
//                    break;
//                case "5":
//                    Console.WriteLine("Ange riktning (N/S/E/W):");
//                    string directionInput = Console.ReadLine();
//                    if (Enum.TryParse(directionInput, out Direction direction))
//                    {
//                        carSimulator.SetDirection(direction);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ogiltig riktning. Försök igen.");
//                    }
//                    break;
//                case "6":
//                    Console.WriteLine("Välj menyoption (Option1/Option2/Option3):");
//                    string menuOptionInput = Console.ReadLine();
//                    if (Enum.TryParse(menuOptionInput, out MenuOption menuOption))
//                    {
//                        carSimulator.SelectMenuOption(menuOption);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ogiltig menyoption. Försök igen.");
//                    }
//                    break;
//                case "7":
//                    carSimulator.DriverFatigue();
//                    break;
//                case "8":
//                    carSimulator.RefuelGasoline();
//                    break;
//                case "9":
//                    Environment.Exit(0);
//                    break;
//                default:
//                    Console.WriteLine("Ogiltigt kommando. Försök igen.");
//                    break;
//            }
//        }
//    }

//}
