namespace Maaltafels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            ShowColoredText("De maaltafels", ConsoleColor.DarkYellow, true);

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("De maaltafels");
            //Console.ResetColor();
            //Console.WriteLine();

            string repeat;

            do
            {

                PracticeTableRow();

                ShowColoredText("Wil je nog meer oefenen? ja/ nee: ", ConsoleColor.White, false);
                
                repeat = Console.ReadLine();
                Console.WriteLine();
            } while (repeat.Equals("ja"));

            Console.WriteLine();
            ShowColoredText("Nu alles door elkaar!", ConsoleColor.Magenta, true);
            
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("Nu alles door elkaar!");
            //Console.ResetColor();
            //Console.WriteLine();

                       

            

            do
            {
                Console.Write("Wat kies je? x of : ");
                string operation = Console.ReadLine();

                switch (operation)
                {

                    case "x":
                        PracticeMultiply();
                        break;

                    case ":":
                        PracticeDivision();
                        break;
                    default:
                        ShowColoredText("Ongeldige invoer!", ConsoleColor.Red, true);
                        
                        break;

                }
                        
                               

                Console.WriteLine();
                ShowColoredText("Proficiat! Goed geoefend!", ConsoleColor.Green, true);

                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Proficiat! Goed geoefend!");
                //Console.WriteLine();
                //Console.ResetColor();

                ShowColoredText("Wil je nog meer oefenen? ja/ nee: ", ConsoleColor.White, false);

                repeat = Console.ReadLine();
                Console.WriteLine();


            } while (repeat.Equals("ja"));
        }

        private static void ShowColoredText(string text, ConsoleColor color, bool appendLine)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            if (appendLine)
            {
                Console.WriteLine();
            }
            Console.ResetColor();

        }

        private static void PracticeTableRow()
        {
            int choice;
            bool isValid;
            
            

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Welke tafel wil je oefenen? ");
                isValid = (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= 10);
                Console.ResetColor();
                Console.WriteLine();

            } while (!isValid);


            for (int i = 0; i < 11; i++)
            {
                int result;

                do
                {

                    Console.Write($"{i} x {choice} = ");
                    int.TryParse(Console.ReadLine(), out result);
                    if (result != (i * choice))
                    {
                        ShowColoredText("Oeps. Probeer nog een keer!", ConsoleColor.Red, true);
                        
                    }
                } while (result != (i * choice));


            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Proficiat! Je kent de tafel van {choice}!");
            Console.ResetColor();
                             


        }

        private static void PracticeMultiply()
        {
            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {

                int number1 = rng.Next(1, 11);
                int number2 = rng.Next(1, 11);
                int result;
                do
                {
                    Console.Write($"{number1} x {number2} = ");
                    int.TryParse(Console.ReadLine(), out result);
                    if (result != (number1 * number2))
                        {
                        ShowColoredText("Bijna... Probeer nog een keer!", ConsoleColor.Red, true);
                        }
                } while (result != (number1 * number2));
            }
        }

        private static void PracticeDivision()
        {

            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {

                int number1 = rng.Next(1, 11);
                int number2 = rng.Next(1, 11);
                int result;
                do
                {
                    Console.Write($"{number1 * number2} : {number2} = ");
                    int.TryParse(Console.ReadLine(), out result);
                    if (result != number1)
                    {
                        ShowColoredText("Oeps. Nog eens proberen!", ConsoleColor.Red, true);
                    }
                } while (result != number1);
            }
        }
}
}
