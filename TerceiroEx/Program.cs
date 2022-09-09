using System;

namespace TerceiroEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if(idade<18)
            {
                Console.WriteLine("Entrada sem permissão");
            }
            else
            {
                Console.WriteLine("Permissão concedida");
            }
        }
    }
}
