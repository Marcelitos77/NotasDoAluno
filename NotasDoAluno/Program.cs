using System;

namespace NotasDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do 1° trimestre:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 2° trimestre:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do 3° trimestre:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = ((nota1 * 30) + (nota2 * 35) + (nota3 * 35)) / 10;

        
            if (media >= 60)
            {
                Console.WriteLine($"Sua média é: {media:f2} e você está aprovado");
            }
            else
            {
                Console.WriteLine($"Sua média é: {media:f2} e você está reprovado");
            }
        }
    }
}
