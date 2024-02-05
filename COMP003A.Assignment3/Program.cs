/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Numeric to Letter Grade
 */

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a numeric grade (1-100): ");
                string input = Console.ReadLine();
                int score = Convert.ToInt32(input);

                if (score >= 90)
                    Console.WriteLine("Letter Grade: A");
                // console output letter grade: A
                else if (score >= 80)
                    Console.WriteLine("Letter Grade: B");
                // console output letter grade: b
                else if (score >= 70)
                    Console.WriteLine("Letter Grade: C");
                // console output letter grade: c
                else if (score >= 60)
                    Console.WriteLine("Letter Grade: D");
                // console output letter grade: d
                else if (score <= 50)
                    Console.WriteLine("Letter Grade: F");
                // console output letter grade: f
                else
                    Console.WriteLine("Invalid Output!");
            }

            
            Console.WriteLine("Enter an integer day of the week (1-7): ");
            string response = Console.ReadLine();
            int number = Convert.ToInt32(response);

            switch (number)
            {
                case 0:
                case 1:
                    Console.WriteLine("String Day: Monday.");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("String day: Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday.");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday.");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday.");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday.");
                    break;
            }
                    
                
                

                
                

            










        }
    }
}
