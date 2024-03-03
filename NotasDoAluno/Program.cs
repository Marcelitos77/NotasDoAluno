using System;

namespace NotaAluno
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

            Aluno aluno = new Aluno(nota1, nota2, nota3);

            aluno.MostrarResultado();
        }
    }

}

