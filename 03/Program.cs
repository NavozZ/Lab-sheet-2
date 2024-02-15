using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class TemperatureTracker
    {
        private double[] dailyTemperatures;

        public TemperatureTracker(int daysInWeek)
        {
            dailyTemperatures = new double[daysInWeek];
        }

        public void InputTemperatures()
        {
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    dailyTemperatures[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature.");
                    i--;
                }
            }
        }

        public void DisplayTemperatureReport()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {6

                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            TemperatureTracker tracker = new TemperatureTracker(7);

            tracker.InputTemperatures();

            tracker.DisplayTemperatureReport();

            Console.ReadKey();
        }
    }
}
