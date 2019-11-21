using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int opc;

            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine(" 1. Registrarse");
            Console.WriteLine(" 2. Salir");
            Console.WriteLine("-----------------");

            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //Registro
                    StreamWriter registro = new StreamWriter("Usuarios.txt", true);

                    string nombre, contra, verificar;


                    Console.Clear();
                    Console.Write("Nombre de Usuario: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Usuario Registrado exitosamente");
                    Console.ReadKey();





                    Console.Clear();
                    Console.WriteLine("Usuario: {0}", nombre);
                    Console.Write("Contraseña: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    contra = Console.ReadLine();
                    Console.ResetColor();
                    if (contra.Length < 7 || contra.Length > 20)
                    {

                        Console.Write(" La contraseña debe tener entre 7 y 20 caracteres");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Usuario: {0}", nombre);

                        Console.Write(" Confirme su contraeña: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        verificar = Console.ReadLine();
                        Console.ResetColor();
                        if (verificar.Equals(contra))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Contraseña confirmada correctamente");
                            registro.Close();
                            Console.ReadKey();
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write(" Las contraseñas no coinciden");
                            Console.Clear();
                            Console.ReadKey();

                        }


                    }

                    break;

                case 2:
                    //Salir
                    Console.Clear();
                    Console.WriteLine("Presione <Enter> para salir");
                    Console.ReadKey();

                    break;

            }

        }


    }
}
