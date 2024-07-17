using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class GeneradorDeDatosAleatorios
    {
        public int NumeroAleatorio(int max)
        {
            Random num = new Random();
            return num.Next(0, max);
        }
        //Devuelve un string aleatorio de la cantidad de caracteres
        public string CadenaAleatoria(int cantidad)
        {
            string resultadoGenerado = "";
            string letras = "qwertyuiopasdfghjklñzxcvbnm";
            int i;
            for (i = 1; i <= cantidad; i++)
            {
                int w = NumeroAleatorio(27);
                char l = letras[w];
                resultadoGenerado = resultadoGenerado + l;
            }
            return resultadoGenerado;
        }

    }
}
