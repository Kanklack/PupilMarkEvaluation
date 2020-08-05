using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pupil_Mark_Evaluation_05
{
    class Program
    {
        static void Menu()
        {
            int[] ReturnedResults = new int[10];

            Console.WriteLine("Press 1 to continue. Press 3 to quit");

            int answer = Convert.ToInt32(Console.ReadLine());

            while (answer != 3)
            {

                Console.WriteLine("*********************************");

                Console.WriteLine("Welcome to my pupil mark evaluation software");

                Console.WriteLine("1. Enter results");

                Console.WriteLine("2. Evalutate results");

                Console.WriteLine("Press 3 to quit");

                Console.Write("Your choice: ");

                answer = Convert.ToInt32(Console.ReadLine());


                if (answer == 1)
                {

                    ReturnedResults = EnterResults();

                }

                else if (answer == 2)
                {

                    Evaluate(ReturnedResults);

                }

            }
            
        }

        static int[] EnterResults()
        {

            int[] results = new int[10];

            for (int i = 0; i < 10; i++)
            {

                Console.Write("Pupil no. {0} score: ", i+1);
                results[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Process completed.");

            return results;

        }

        static void Evaluate(int[] results)
        {

            int highestmark = results.Max();
            int lowestmark = results.Min();
            double averagemark = Queryable.Average(results.AsQueryable());

            Console.WriteLine("Evaluating score");
            Console.WriteLine("Highest mark is: {0}", highestmark);
            Console.WriteLine("Lowest mark is: {0}", lowestmark);
            Console.WriteLine("Average mark is: {0}", averagemark);

        }

        static void Main(string[] args)
        {

            Menu();

            Console.Read();

        }
    }
}
