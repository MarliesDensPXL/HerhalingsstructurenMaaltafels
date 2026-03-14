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

                Console.Write("Welke tafel wil je oefenen? ");
                isValid = int.TryParse(Console.ReadLine(), out choice);
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

            

        }
    }
}
