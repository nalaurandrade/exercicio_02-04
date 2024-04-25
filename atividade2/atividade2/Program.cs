int[,] matriz = new int[5, 4];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite a matrícula do aluno {i + 1}: ");
    matriz[i, 0] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Digite a média das provas do aluno {i + 1}: ");
    matriz[i, 1] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Digite a média dos trabalhos do aluno {i + 1}: ");
    matriz[i, 2] = Convert.ToInt32(Console.ReadLine());

    matriz[i, 3] = matriz[i, 1] + matriz[i, 2];

    Console.Write($"A nota final do Aluno {i + 1} é: ");
    Console.Write($"{matriz[i, 3]}");

    Console.Write("\n ");
    Console.Write("\n---------------------------------\n");
}

int maiorNotaFinal = -1;
int matriculaMaiorNota = -1;

for (int i = 0; i < 5; i++)
{
    if (matriz[i, 3] > maiorNotaFinal)
    {
        maiorNotaFinal = matriz[i, 3];
        matriculaMaiorNota = matriz[i, 0];
    }
}
Console.WriteLine($"Matrícula do aluno com a maior nota final: {matriculaMaiorNota}");


double somaNotasFinais = 0;
for (int i = 0; i < 5; i++)
{
    somaNotasFinais += matriz[i, 3];
}
double mediaNotasFinais = somaNotasFinais / 5;
Console.WriteLine($"Média aritmética das notas finais: {mediaNotasFinais}");