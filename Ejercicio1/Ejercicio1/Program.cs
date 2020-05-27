using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero: ");
            string numero = Console.ReadLine();
            string invertido = null;

            int num = Convert.ToInt32(numero);

            if (num > 0)
            {
                invertido = Convert.ToString(num % 10);
                num = num / 10;
                while (num > 0)
                {
                    invertido += Convert.ToString(num % 10);
                    num = num / 10;
                }
                Console.WriteLine("Numero invertido: " + invertido);
            }
            else
            {
                Console.WriteLine("El numero es menor o igual a cero!");
            }
            
        }
    }
}
