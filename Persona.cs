using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloword
{
    internal class Persona
    {
        public string Nombre;
        public int Edad;

        public static int cantidad;
        public readonly double PI = 3.14159;


        public void Saludar()
        {
            Console.WriteLine($"Hola mi nombre es {Nombre} y tengo {Edad} años.");
        }

    }
}
