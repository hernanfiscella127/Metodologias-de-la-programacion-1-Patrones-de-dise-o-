using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    internal class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero ");
            int nume = Int32.Parse(Console.ReadLine());
            return nume;
        }
        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese caracteres ");
            string letras = Console.ReadLine();
            return letras;
        }
    }
}
