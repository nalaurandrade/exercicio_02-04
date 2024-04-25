using System;

class Program
{
    static void Main(string[] args)
    {
        int[] pares = new int[5];
        int[] impares = new int[5];
        int countPares = 0, countImpares = 0;
        int totalNumeros = 0;

        while (totalNumeros < 15)
        {
            int numero = int.Parse(Console.ReadLine());
            totalNumeros++;

            if (numero % 2 == 0)
            {
                pares[countPares] = numero;
                countPares++;
            }
            else
            {
                impares[countImpares] = numero;
                countImpares++;
            }

            if (countPares == 5)
            {
                ImprimirVetor("Pares", pares);
                countPares = 0;
            }

            if (countImpares == 5)
            {
                ImprimirVetor("Ímpares", impares);
                countImpares = 0;
            }
        }

        
        if (countPares > 0)
        {
            ImprimirVetor("Pares", pares, countPares);
        }

        if (countImpares > 0)
        {
            ImprimirVetor("Ímpares", impares, countImpares);
        }
    }

    static void ImprimirVetor(string tipo, int[] vetor, int count = 5)
    {
        Console.WriteLine($"Elementos {tipo}:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{tipo} [{i}] = {vetor[i]}");
        }
    }
}
