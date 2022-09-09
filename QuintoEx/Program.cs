using System;

namespace QuintoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorMatricula;
            Double maiorAltura;

            int menorMatricula;
            Double menorAltura;

            int matricula;
            Double altura;

            Console.Write("Matrícula do aluno 1:\n");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Altura do aluno 1:\n");
            altura = Convert.ToDouble(Console.ReadLine());

            maiorMatricula = matricula;
            maiorAltura = altura;
            menorMatricula = matricula;
            menorAltura = altura;

            int i = 1;
            while(i<10)
            {
                Console.Write("Matricula do aluno "+(i+1)+":\n");
                matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Altura do aluno "+(i+1)+":\n");
                altura = Convert.ToDouble(Console.ReadLine());

                if(maiorAltura<altura)
                {
                    maiorMatricula = matricula;
                    maiorAltura = altura;
                }
                if(menorAltura>altura)
                {
                    menorAltura = altura;
                    menorMatricula = matricula;
                }
                i++;
            }

            Console.Write("Maior aluno: ");
            Console.WriteLine("Matrícula: {0} - altura: {1}\n", maiorMatricula, maiorAltura);

            Console.Write("Menor aluno: ");
            Console.WriteLine("Matricula: {0} - Altura: {1}", menorMatricula, menorAltura);

        }
    }
}