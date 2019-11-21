using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string u, con, p;
            int user = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Inicio de sesión");
                Console.Write("Usuario: ");
                u = Console.ReadLine();

                Console.Write("Contraseña: ");
                Console.ForegroundColor = ConsoleColor.Black;
                con = Console.ReadLine();
                p = u + ":" + con;
                Console.ResetColor();
                if (V(p) == true)
                {
                    Console.WriteLine("Ingresado correctamente");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    user++;
                }

            } while (user != 3);
            if (user == 3)
            {

                Console.WriteLine("El sistema fue bloqueado");
                Console.ReadLine();
            }


        }

        static bool V(string key)
        {
            string datos;
            bool correct = false;
            StreamReader b = new StreamReader("Usuarios.txt");
            do
            {
                datos = b.ReadLine();
                if (datos == key)
                {
                    correct = true;
                }

            } while (datos != null);
            return correct;
        }

    }
}
