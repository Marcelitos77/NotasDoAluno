using System;

namespace NotaAluno
{
    class Aluno
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public Aluno(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularMedia()
        {
            return ((Nota1 * 30) + (Nota2 * 35) + (Nota3 * 35)) / 10;
        }

        public void MostrarResultado()
        {
            double media = CalcularMedia();

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
