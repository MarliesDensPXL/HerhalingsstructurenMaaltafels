namespace Maaltafels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("De maaltafels");
            Console.ResetColor();
            Console.WriteLine();

            int choice;
            bool isValid;

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Welke tafel wil je oefenen? ");
                isValid = (int.TryParse(Console.ReadLine(), out choice) && choice > 0);
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
                } while (result != (i * choice));


            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Proficiat! Je kent de tafel van {choice}!");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("En nu alles door elkaar!");
            Console.ResetColor();
            Console.WriteLine();

            Random rng = new Random();
            string repeat;
            do
            {

                for (int i = 0; i < 10; i++)
                {

                    int number1 = rng.Next(1, 11);
                    int number2 = rng.Next(1, 11);
                    int result;
                    do
                    {
                        Console.Write($"{number1} x {number2} = ");
                        int.TryParse(Console.ReadLine(), out result);
                    } while (result != (number1 * number2));
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Proficiat! Goed geoefend!");
                Console.WriteLine();
                Console.ResetColor();

                Console.Write("Wil je nog meer oefenen? ja/nee: ");
                repeat = Console.ReadLine();
                Console.WriteLine();

            } while (repeat.Equals("ja"));
        }
    }
}
