using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{    //Factory method paso 2 super clases de fabrica ( crear las fabricas) implementar el metodo abstacto

    internal class FabricaDePersonas : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios gx = new GeneradorDeDatosAleatorios();
            Comparable x=  new Persona(gx.CadenaAleatoria(10), gx.NumeroAleatorio(100000000));
            return x;
        }
    }
}
