using System;

namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nota dos alunos");

            float soma = 0;
            float notas = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
            }
            notas = soma / 3;
            Console.WriteLine("media é igual a: " + notas);
            Console.ReadKey();
        }
    }
}