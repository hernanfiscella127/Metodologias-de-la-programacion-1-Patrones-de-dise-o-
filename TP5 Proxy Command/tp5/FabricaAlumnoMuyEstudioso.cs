using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class FabricaAlumnoMuyEstudioso : FabricaDeComparables
    {
        public override Comparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios a = new GeneradorDeDatosAleatorios();

            Comparable s = new AlumnoMuyEstudioso(a.CadenaAleatoria(6), a.NumeroAleatorio(60000000), a.NumeroAleatorio(2000), a.NumeroAleatorio(10));
            s = new ImprimirNota((IAlumno)s);
            s = new ImprimirLegajo((IAlumno)s);
            s = new ImprimirEstado((IAlumno)s);
            s = new ImprimirRecuadro((IAlumno)s);
            return s;
        }
    }
}
