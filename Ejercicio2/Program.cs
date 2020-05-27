using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero1 = null;
            string numero2 = null;
            string opcion = null;
            int resultado;
            do
            {
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("5- Salir");
                Console.WriteLine("Opcion: ");
                opcion = Console.ReadLine();

                switch (Convert.ToInt32(opcion))
                {
                    case 1:
                        Console.WriteLine("Escribe un numero: ");
                        numero1 = Console.ReadLine();

                        Console.WriteLine("Escribe otro numero: ");
                        numero2 = Console.ReadLine();

                        resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);

                        Console.WriteLine("La suma es: " + resultado);
                        break;

                    case 2:
                        Console.WriteLine("Escribe un numero: ");
                        numero1 = Console.ReadLine();

                        Console.WriteLine("Escribe otro numero: ");
                        numero2 = Console.ReadLine();

                        resultado = Convert.ToInt32(numero1) - Convert.ToInt32(numero2);

                        Console.WriteLine("La resta es: " + resultado);
                        break;

                    case 3:
                        Console.WriteLine("Escribe un numero: ");
                        numero1 = Console.ReadLine();

                        Console.WriteLine("Escribe otro numero: ");
                        numero2 = Console.ReadLine();

                        resultado = Convert.ToInt32(numero1) * Convert.ToInt32(numero2);

                        Console.WriteLine("EL producto es: " + resultado);
                        break;

                    case 4:
                        Console.WriteLine("Escribe un numero: ");
                        numero1 = Console.ReadLine();

                        Console.WriteLine("Escribe otro numero: ");
                        numero2 = Console.ReadLine();

                        resultado = Convert.ToInt32(numero1) / Convert.ToInt32(numero2);

                        Console.WriteLine("La division es: " + resultado);
                        break;
                }
            } while (Convert.ToInt32(opcion) != 5);
        }
    }
}
