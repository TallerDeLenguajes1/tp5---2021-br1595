using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string Oracion1, Oracion2;

            Console.WriteLine("Primer oración");
            Oracion1 = IngresarCadena();
            Console.WriteLine("Segunda oración");
            Oracion2 = IngresarCadena();

            Operaciones(Oracion1, Oracion2);

        }

        static string IngresarCadena()
        {
            string cadena;

            Console.Write($"\nIngrese una oración:");
            cadena = Console.ReadLine().Trim();

            return cadena;
        }

        static void Operaciones(string Cadena, string Cadena2)
        {
            int Auxiliar;
            string CadenaAuxiliar, Cadena3;
			Random r= new Random ();

            Auxiliar = Cadena.Length;
            Console.WriteLine($"\nObtener algunas letras que forman parte de una cadena");
            Console.WriteLine($"Primer caracter de la cadena: {Cadena[0]}");            
            Console.WriteLine($"Caracter aleatorio de la cadena: {Cadena[r.Next(Auxiliar)]}");
            Console.WriteLine($"Ultimo caracter de la cadena: {Cadena[Auxiliar - 1]}");

            //Obtener la longitud de la cadena y muestre por pantalla
            Console.WriteLine($"Longitud de la cadena: {Auxiliar} caracteres");

            // Concatenar (Unir) dos cadenas distintas
            CadenaAuxiliar = Cadena + " " + Cadena2;
            Console.WriteLine($"\nConcatenacion de las cadenas ingresadas:\n{CadenaAuxiliar}\n" );

            
            // Extraer una subcadena
            string[] SubCadena = CadenaAuxiliar.Split( );
            Console.WriteLine($"\nUna subcadena de la cadena concatenada dividida en los espacios: {SubCadena[0]}\n");

            /* Utilizando la calculadora creada anteriormente realizar las operaciones de dos
            números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
            la suma sería:
            “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
            Donde num1, num2 y resultados son los sumandos y el resultado de la operación
            respectivamente .*/

            //Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
            foreach (var c in CadenaAuxiliar)
            {
                Console.Write($"{c}\n");
            }
            
            //Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.WriteLine("\nIngrese una palabra a buscar:");            
            string Palabra = Console.ReadLine().Trim();

            Console.WriteLine($"La palabra {Palabra} {(CadenaAuxiliar.Contains(Palabra) ? "está" : "no está")} dentro de la oración {CadenaAuxiliar}");
        
            //Convierta la cadena a Mayúsculas y luego minúsculas
            Console.WriteLine($"\nLa oración en mayúsculas: {CadenaAuxiliar.ToUpper()}");
            Console.WriteLine($"La oración en minúsculas: {CadenaAuxiliar.ToLower()}\n");
            
            //Ingrese una nueva cadena y luego compare los valores de ambas.
            Cadena3 = IngresarCadena();
            Console.WriteLine($"{Cadena} y {Cadena3}");
            Console.WriteLine($"{(Cadena.Equals(Cadena3) ? "Las oraciones son iguales." : "Las oraciones son diferentes.")}");
            Console.WriteLine($"{Cadena2} y {Cadena3}");
            Console.WriteLine($"{(Cadena2.Equals(Cadena3) ? "Las oraciones son iguales." : "Las oraciones son diferentes.")}");

            //Ingrese una cadena separada por caracteres que usted determine y muestre por
            //pantalla los resultados (Revisar el comportamiento de split())
            
            Console.WriteLine("\nIngrese caracter a utilizar para dividir una oración antes ingresada.");
            char CaracterAUsar = Convert.ToChar(Console.ReadLine());

            foreach (var SubCadenita in Cadena.Split(CaracterAUsar))
            {
                Console.WriteLine($"{SubCadenita}");
            }

            //● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
            //simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
            //por pantalla “582+2” y que le devuelva la suma de 582 con 2

            Console.WriteLine("\nIngrese operación resolver (Ejemplo: 582+2)");
            string Operacion = Console.ReadLine().Trim();
            string[] OperacionAuxiliar;
            int Opcion;
            
            if(Operacion.Contains('+'.ToString()))
            {
                OperacionAuxiliar = Operacion.Split('+');   
                Opcion = 1;
                Enviar(Opcion, float.Parse(OperacionAuxiliar[0]), float.Parse(OperacionAuxiliar[1]));

            }
            else if(Operacion.Contains('-'.ToString()))
            {
                OperacionAuxiliar = Operacion.Split('-');   
                Opcion = 2;
                Enviar(Opcion, float.Parse(OperacionAuxiliar[0]), float.Parse(OperacionAuxiliar[1]));
            }
            else if(Operacion.Contains('*'.ToString()))
            {
                OperacionAuxiliar = Operacion.Split('*');   
                Opcion = 3;
                Enviar(Opcion, float.Parse(OperacionAuxiliar[0]), float.Parse(OperacionAuxiliar[1]));
            }
            else if(Operacion.Contains('/'.ToString()))
            {
                OperacionAuxiliar = Operacion.Split('/');   
                Opcion = 4;
                Enviar(Opcion, float.Parse(OperacionAuxiliar[0]), float.Parse(OperacionAuxiliar[1]));
            }
            else
            {
                Console.WriteLine("La cadena ingresada no es una ecuación.");
            }


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
                    Console.WriteLine("\nDivision\n {0} / {1} = {2}", Dato1, Dato2, Dato1 / Dato2);
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
