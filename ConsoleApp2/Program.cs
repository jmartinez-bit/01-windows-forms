using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir 10 primeros números primos");
                Console.WriteLine("[7] Conversión de celcius a farenheit");
                Console.WriteLine("[8] Conversión de farenheit a celcius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese los grados celcius a convertir");
                        double i = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La conversión a farenheit es {0}", ConversionFarenheit(i));
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese los grados farenheit a convertir");
                        double j = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La conversión a farenheit es {0}", ConversionCelcius(j));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }

        static double ConversionFarenheit(double i)
        {
            return (i * 1.8) + 32;
        }

        static double ConversionCelcius(double j)
        {
            return (j - 32) / 1.8;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Primos()
        {
            int n = 2;
            int total = 1;
            while (total <= 10)
            {
                Boolean esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }

                n++;
            }
        }
    }
}
