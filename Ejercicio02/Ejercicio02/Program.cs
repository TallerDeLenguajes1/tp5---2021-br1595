using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        public static void Main(string[] args)
        {
            char Opcion = 's';

            do
            {
                Menu();
                Opcion = Pregunta();

            } while (Opcion == 's');

            Console.WriteLine("Fin de ejecucion");

        }

        static char Pregunta()//Funcion para saber si se seguira operando
        {
            char Opcion;

            Console.WriteLine("\nDesea realizar otra operacion? (s/n)");
            Opcion = Char.ToLower(Convert.ToChar(Console.ReadLine()));//recibe como entrada una string que la transforma en caracter y en minuscula

            if (Opcion == 's' || Opcion == 'n')
            {
                return Opcion;
            }
            else
            {
                Console.WriteLine("Opcion incorrecta, intente nuevamente.\n");
                return Pregunta();
            }

        }

        static void Menu()//funcion menu con todas sus opciones solicitadas
        {
            int Opcion;
            float Dato1, Dato2;

            Console.WriteLine("Calculadora Simple\n");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("\nIngrese opción:");

            Opcion = Recibir();
            Console.WriteLine("\nIngrese primer dato:");
            Dato1 = Recibir2(Opcion);
            Console.WriteLine("\nIngrese segundo dato:");
            Dato2 = Recibir2(Opcion);
            Enviar(Opcion, Dato1, Dato2);
        }

        static int Recibir()
        {
            int Opcion;

            Opcion = Convert.ToInt32(Console.ReadLine());

            if (Opcion > 1 && Opcion <= 4)
            {
                return Opcion;
            }
            else
            {
                Console.WriteLine("Opcion Incorrecta, intente nuevamente\n");
                return Recibir();
            }
        }

        static float Recibir2(int Opcion)//funcion que para ingresar un dato por vez a operar
        {
            float Dato;

            if (Opcion == 4)
            {
                Console.WriteLine("Tenga en cuenta que la división por 0 no se encuentra definida y al realizar la operación obtendrá infinito.");
            }
            Dato = float.Parse(Console.ReadLine());

            return Dato;
        }

        static void Enviar(int Opcion, float Dato1, float Dato2)//funcion con un switch que se encarga de realizar las operaciones
        {
            switch (Opcion)
            {
                case 1:
                    Console.WriteLine("\nSuma\n {0} + {1} = {2}", Dato1, Dato2, Dato1 + Dato2);
                    break;
                case 2:
                    Console.WriteLine("\nResta\n {0} - {1} = {2}", Dato1, Dato2, Dato1 - Dato2);
                    break;
                case 3:
                    Console.WriteLine("\nMultiplicacion\n {0} * {1} = {2}", Dato1, Dato2, Dato1 * Dato2);
                    break;
                case 4:
                    Console.WriteLine("\nDivision\n {0} / {1} = {2}, Dato1, Dato2, Dato1 / Dato2);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Apriete la tecla enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
