using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenSubSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int m = 3;

            var result = pickMRandomly(input, m);

            Console.WriteLine("{0} randomly picked values are", m);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        static int[] pickMRandomly(int[] input, int m)
        {
            int[] clonedInput = new int[input.Length];

            input.CopyTo(clonedInput, 0);

            int n = clonedInput.Length;

            int[] subset = new int[m];

            Random randomGenerator = new Random();

            for (int j = 0; j < m; j++)
            {
                // random.Next generates a value
                // that's inclusive of the lower bound
                // but excludes the upper bound
                int rand = randomGenerator.Next(j, n);

                subset[j] = clonedInput[rand];

                // Now swap clonedInput[rand] with 
                // clonedInput[j] so that the jth spot
                // can be marked as dead

                int temp = clonedInput[rand];
                clonedInput[rand] = clonedInput[j];
                clonedInput[j] = temp;
            }

            return subset;
        }
    }
}
