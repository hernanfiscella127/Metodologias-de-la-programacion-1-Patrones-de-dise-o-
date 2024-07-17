using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class ImprimirLegajo : Decorador
    {
        public ImprimirLegajo(IAlumno a):base( a)
        {
             

        }
        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion()+ "(" + this.GetLegajo();
        }
    }
}
