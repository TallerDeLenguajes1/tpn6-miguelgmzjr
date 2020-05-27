using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            string numero = Console.ReadLine();
            int num = Convert.ToInt32(numero);

            Console.WriteLine("Ingrese un numero decimal: ");
            string numero2 = Console.ReadLine();
            float num2 = (float) Convert.ToDouble(numero);

            Console.WriteLine("El valor absoludo es: " + Math.Abs(num));
            Console.WriteLine("El cuadrado del numero es: " + Math.Pow(num, 2));
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(num));
            Console.WriteLine("El seno del numero en radianes es: " + Math.Sin((num * (Math.PI)) / 180));
            Console.WriteLine("El coseno del numero en radianes es: " + Math.Cos((num * (Math.PI)) / 180));
            Console.WriteLine("La parte entera del numero es: " + Math.Truncate(num2));



            Console.WriteLine("Ingrese un numero: ");
            string numero3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numero3);

            Console.WriteLine("Ingrese un numero: ");
            string numero4 = Console.ReadLine();
            int num4 = Convert.ToInt32(numero4);

            if (num3 > num4)
            {
                Console.WriteLine("El numero mayor es " + num3 + " y el menor es " + num4);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num4 + " y el menor es " + num3);
            }
        }
    }
}
