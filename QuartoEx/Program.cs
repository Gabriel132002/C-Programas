using System;

namespace QuartoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual das quatro operações deseja fazer?");
            Console.WriteLine("Divisão");
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Soma");
            Console.WriteLine("Subtração");
            Console.WriteLine("Escrever sem caracteres especiais");
            string ler = Console.ReadLine();


            if(ler=="divisao")
            {
                int x;
            Console.WriteLine("Valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            x=valor1/valor2;

            Console.WriteLine("Resultado = "+x);
            }

            if(ler=="multiplicacao")
            {
                int x;
            Console.WriteLine("Valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            x=valor1*valor2;

            Console.WriteLine("Resultado = "+x);
            }

            if(ler=="soma" || ler=="adicao")
            {
                int x;
            Console.WriteLine("Valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            x=valor1+valor2;

            Console.WriteLine("Resultado = "+x);
            }

            if(ler=="subtracao")
            {
                int x;
            Console.WriteLine("Valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            x=valor1-valor2;

            Console.WriteLine("Resultado = "+x);
            }
        }
    }
}