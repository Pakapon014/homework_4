using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the total number of road segments (N) and the maximum distance (K):");
        string[] input = Console.ReadLine().Split(' ');

        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        Console.WriteLine("Enter the population in each road segment (separated by spaces):");
        string[] populationInput = Console.ReadLine().Split(' ');

        int[] population = new int[N];

        for (int i = 0; i < N; i++)
        {
            population[i] = int.Parse(populationInput[i]);
        }

        int maxCustomers = FindMaxCustomers(population, N, K);
        Console.WriteLine("Maximum number of customers: " + maxCustomers * 2);
    }

    static int FindMaxCustomers(int[] population, int N, int K)
    {
        int maxCustomers = 0;

        for (int i = 0; i <= N - K; i++)
        {
            int currentCustomers = 0;

            for (int j = i; j < i + K; j++)
            {
                currentCustomers += population[j];
            }

            if (currentCustomers > maxCustomers)
            {
                maxCustomers = currentCustomers;
            }
        }

        return maxCustomers;
    }
}
