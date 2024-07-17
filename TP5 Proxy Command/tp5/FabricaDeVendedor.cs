using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    internal class FabricaDeVendedor : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios a = new GeneradorDeDatosAleatorios();

            Comparable s = new Vendedor(a.CadenaAleatoria(6), a.NumeroAleatorio(60000000), a.NumeroAleatorio(50000));

            return s;
        }
        /*public override Comparable CrearPorTeclado()
        {
            LectorDeDatos dato = new LectorDeDatos();
            Comparable s = new Vendedor(dato.stringPorTeclado(), dato.numeroPorTeclado(), dato.numeroPorTeclado());
            return s;
        }*/
    }
}

