using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public abstract class FabricaDeComparables // se encarga de llamar a las calses que si saben fabricar ese producto
    {
        public static Comparable crearAleatorio(int queProducto)//hay que pasarle que producto quiere fabricar para seleccionarlo con el swith case
        {
            FabricaDeComparables fabrica = null;
            switch (queProducto)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica = new FabricaDePersonas(); break;
                case 3: fabrica = new FabricaDeAlumnos(); break;
                case 4: fabrica = new FabricaAlumnoMuyEstudioso(); break;
                case 5: fabrica = new FabricaDeVendedor(); break;
            }
            return fabrica.CrearAleatorio();
        }

        public abstract Comparable CrearAleatorio();

    }

}
