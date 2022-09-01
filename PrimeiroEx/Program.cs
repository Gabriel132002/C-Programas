using System;

namespace PrimeiroEx
{
        class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite seu salário");
            Double salario = Convert.ToDouble(Console.ReadLine());
            
            if(salario<2300)
            {
                salario = salario + 500;
                Console.WriteLine("Seu salário após o reajuste = "+salario);
            }
            else
            {
                salario = salario + 350;
                Console.WriteLine("Seu salário após o reajuste = "+salario);
            }
        }
    }
}