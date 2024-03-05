using System;

namespace Coding.Exercise
{
    public class TemperatureAnalyzer
    {
            // Znajduje najwyższą temperaturę w tablicy temperatur
            public static int FindHighestTemperature(int[] temperatures)
            {
                int highestTemp = temperatures[0];

                for (int i = 0; i < temperatures.Length; i++)
                {
                    if (temperatures[i] > highestTemp)
                    {
                        highestTemp = temperatures[i];
                    }
                }
                return highestTemp;
            }

            // Znajduje najniższą temperaturę w tablicy temperatur
            public static int FindLowestTemperature(int[] temperatures)
            {   
            
                int lowestTemp = temperatures[0];

                foreach (int i in temperatures)
                {

                    if (lowestTemp > i)
                    {
                    lowestTemp = i;
                    }
                }
                return lowestTemp;
            }
            public static void Main(string[] args)
        {
            int[] temperatures = { 5, 6, 3, 9, 8, 1, 3, };
            int highestTemp = FindHighestTemperature(temperatures);
            int lowestTemp = FindLowestTemperature(temperatures);
            Console.WriteLine(highestTemp);
            Console.WriteLine(lowestTemp);
        }
        }
    }
