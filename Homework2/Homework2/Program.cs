using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // -------------------- homeWork2

            Console.WriteLine("Kā tevi sauc");
            string userName = Console.ReadLine();
            Console.WriteLine("Sveiks, + userName");

            // -------------------------------------------

            Console.WriteLine("Kāds ir tavs vecums?");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);
            int yearAge = age;
            Console.WriteLine("Sveiks, cik gadu tev būs nākošgad?", yearAge);
            int yarAge = age;
            Console.WriteLine("Nākamgad tev paliks, yearAge + 1");


            // ------------------------------------------------------

            int maxNumber1 = 20;
            int maxNumber2 = 80;
            int maxResult = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine(maxResult);

            // ----------------------------------------------------------

            int minNumber1 = 80;
            int minNumber2 = 30;
            int minResult = Math.Min(minNumber1, minNumber2);
            Console.WriteLine(minResult);

            // --------------------------------------------------------------


            int divisionReminder1 = 10;
            int divisionReminders2 = 4;
            int divisionRemindersResult = divisionReminder1 % divisionReminders2;
            Console.WriteLine(divisionRemindersResult);

            // ----------------------------------------------------------

            double numberToRound = 14.786;
            double rounded = Math.Round(numberToRound, 2);
            Console.WriteLine(rounded);

            // ---------------------------------------------------

            




            {

            }
        }
    }
}
