using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[20];

        Console.WriteLine("Digite 20 numeros:");

        for (int i = 0; i < 20; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < 10; i++)
        {
            int temp = vetor[i];
            vetor[i] = vetor[19 - i];
            vetor[19 - i] = temp;
        }


        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"N[{i}] = {vetor[i]}");
        }
    }
}
