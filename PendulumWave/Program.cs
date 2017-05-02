using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PendulumWave
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Enter how many pendulums will be in the wave.");
                int penCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number cycles for the wave.");
                int cycles = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the max time, in seconds, that the pendulum will swing.");
                int maxSeconds = int.Parse(Console.ReadLine());

                for (int i = 0; i < penCount; i++)
                {
                    string output = string.Format("{0} {1}", ("Pendulum " + (i + 1) + ":").PadRight(10), CalculatePendulum(i, maxSeconds, cycles).ToString().PadLeft(5));
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(output);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(output);
                    }
                    
                }

                Console.ReadKey();
            }
        }

        static float CalculatePendulum(int n, int seconds, int k)
        {
            float length = 9.81f * (float)Math.Pow((seconds / (2 * Math.PI * (k + n + 1))), 2);
            length *= 100;
            length = (float)Math.Round(length, 3);
            return length;
        }



    }
}
