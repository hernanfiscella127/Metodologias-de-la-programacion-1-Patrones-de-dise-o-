using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class ImprimirCalificacion: Decorador
    {
        public ImprimirCalificacion(IAlumno a) : base(a)
        {


        }
        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion()+ "/" + this.GetCalificacion() + ")" + "            " + this.GetCalificacion();
        }
    }
}
