using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{    //Factory method paso 2 super clases de fabrica ( crear las fabricas) implementar el metodo abstacto

    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios a = new GeneradorDeDatosAleatorios();

            Comparable s = new numero(a.NumeroAleatorio(100));
            return s;
        }
    }
}
