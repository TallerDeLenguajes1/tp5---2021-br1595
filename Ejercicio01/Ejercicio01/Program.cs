using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso;

            Console.WriteLine("Ingrese número:");
            ingreso = Convert.ToInt32(Console.ReadLine());

            if (ingreso >= 0)
            {
                Console.WriteLine("\nNúmero invertido:");
                for (int i = 1; i <= ingreso.ToString().Length; i++)
                {
                    Console.Write(ingreso.ToString()[ingreso.ToString().Length - i]);
                }
            }
            else
            {
                Console.WriteLine("\nEl numero ingresado es menor o igual a 0");
            }
            Console.ReadLine();
        }
    }
}
