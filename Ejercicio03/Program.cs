using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
            Menu2();

            Console.WriteLine("Fin de ejecucion");
        }

        static void Menu()
        {
            float Dato1;

            Console.WriteLine("\nIngrese un número:");
            Dato1 = Recibir();
            Operaciones(Dato1);
        }

        static void Menu2()
        {
            float Dato1, Dato2;

            Console.WriteLine("\nIngrese dos números a comparar\nIngrese el primer número:");
            Dato1 = Recibir();

            Console.WriteLine("\nIngrese el segundo número:");
            Dato2 = Recibir();

            Operaciones2(Dato1, Dato2);
        }

        static float Recibir()//funcion para ingresar un dato por vez a operar
        {
            float Dato;

            Dato = float.Parse(Console.ReadLine());

            return Dato;
        }

        static void Operaciones(float Dato1)
        {
            Console.WriteLine("Operaciones para '{0}'", Dato1);

            //El valor absoluto de un número
            Console.WriteLine("Valor absoluto: '{0}'", Math.Abs(Dato1));

            //El cuadrado
            Console.WriteLine("Cuadrado: '{0}'", Math.Pow(Dato1, 2.0));

            //La raíz cuadrada
            Console.WriteLine("Raíz caudrada: '{0}'", Math.Sqrt(Dato1));

            //El seno
            Console.WriteLine("Seno: '{0}'", Math.Sin(Dato1));

            //El Coseno
            Console.WriteLine("Coseno: '{0}'", Math.Cos(Dato1));

            //La parte entera de un tipo float.
            Console.WriteLine("Parte entera: '{0}'", Math.Truncate(Dato1));

            Console.WriteLine("Apriete la tecla enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }

        static void Operaciones2(float Dato1, float Dato2)
        {
            //Luego de esto, solicite dos números al usuario y determine:
            Console.WriteLine("Operaciones para los números '{0}' y '{1}'", Dato1, Dato2);
            //El Máximo entre los dos números
            Console.WriteLine("Máximo: '{0}'", Math.Max(Dato1, Dato2));

            //El Mínimo entre los dos números
            Console.WriteLine("Mínimo: '{0}'\n\n", Math.Min(Dato1, Dato2));

            Console.WriteLine("Apriete la tecla enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
