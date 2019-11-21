using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int opc;


            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine(" 1. Agregar pais");
            Console.WriteLine(" 2. Mostrar países");
            Console.WriteLine(" 3. Buscar pais");
            Console.WriteLine(" 4. Salir");
            Console.WriteLine("-----------------");

            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //Agregar pais

                    Console.Clear();
                    StreamWriter archivo = new StreamWriter("Arreglo.txt", true);
                    string[] Paises;
                    int cant;
                    string NP;
                    Console.Write("Cantidad de paises que desea agregar: ");
                    cant = Convert.ToInt32(Console.ReadLine());
                    Paises = new string[cant];
                    for (int i = 1; i <= cant; i++)
                    {
                        Console.Write("Pais: ");
                        NP = Console.ReadLine();
                        archivo.WriteLine(NP);
                    }

                    Console.Write("Presione <Enter> para salir");
                    archivo.Close();
                    Console.ReadKey();
                    break;

                case 2:
                    //Mostrar pais

                    string linea;
                    StreamReader mostrar = new StreamReader("Arreglo.txt");
                    Console.Clear();
                    linea = mostrar.ReadToEnd();
                    Console.Write(linea);
                    Console.Write("Presione <Enter> para salir");
                    mostrar.Close();
                    Console.ReadKey();
                    break;

                case 3:
                    //Buscar pais

                    StreamReader mostrar1 = new StreamReader("Arreglo.txt");
                    string text;
                    string b;
                    Console.Clear();
                    Console.WriteLine("Ingrese el pais que desea buscar: ");
                    b = Console.ReadLine();

                    do
                    {
                        text = mostrar1.ReadLine();


                        if (text != null)
                        {
                            if (text.Equals(b))
                            {

                                Console.Clear();
                                Console.WriteLine("Pais encontado: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(b);
                                Console.ResetColor();

                            }

                            else
                            {
                                Console.Clear();
                                Console.Write("El pais agregado no se encuentra en la lista actual");
                                Console.WriteLine("Presione <Enter> para salir");
                                Console.ReadKey();
                            }


                        }


                    } while (text != null);
                    Console.WriteLine("Presione <Enter> para continuar");
                    Console.ReadKey();


                    break;

                case 4:
                    //Salir

                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    Console.ReadKey();

                    break;



            }

        }

    }
}
