using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class ImprimirEstado : Decorador
    {

        public ImprimirEstado(IAlumno a) : base(a)
        {


        }
        public override string mostrarCalificacion()
        {
            switch (this.GetCalificacion())
            {

                case 1:
                    return base.mostrarCalificacion() + " (DESAPROBADO)";
                case 2:
                    return base.mostrarCalificacion() + " (DESAPROBADO)";
                case 3:
                    return base.mostrarCalificacion() + " (DESAPROBADO)";
                case 4:
                    return base.mostrarCalificacion() + " (APROBADO)";
                case 5:
                    return base.mostrarCalificacion() + " (APROBADO)";
                case 6:
                    return base.mostrarCalificacion() + " (APROBADO)";
                case 7:
                    return base.mostrarCalificacion() + " (PROMOCIONA)";
                case 8:
                    return base.mostrarCalificacion() + " (PROMOCIONA)";
                case 9:
                    return base.mostrarCalificacion() + " (PROMOCIONA)";
                case 10:
                    return base.mostrarCalificacion() + " (PROMOCIONA)";
                default: return "ERROR";

            }
            
        }
    }
}
