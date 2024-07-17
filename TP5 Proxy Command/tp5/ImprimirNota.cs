using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class ImprimirNota : Decorador
    {
        public ImprimirNota(IAlumno a) : base(a)
        {


        }
        public override string mostrarCalificacion()
        {
            switch (this.GetCalificacion())
            {   

                case 1:
                    return base.mostrarCalificacion() + " (Uno)";
                case 2:
                    return base.mostrarCalificacion() + " (Dos)";
                case 3:
                    return base.mostrarCalificacion() + " (Tres)";
                case 4:
                    return base.mostrarCalificacion() + " (Cuatro)";
                case 5:
                     return base.mostrarCalificacion() + " (Cinco)";
                case 6:
                     return base.mostrarCalificacion() + " (Seis)";
                case 7:
                    return base.mostrarCalificacion() + " (Siete)";
                case 8:
                    return base.mostrarCalificacion() + " (Ocho)";
                case 9:
                    return base.mostrarCalificacion() + " (Nueve)";
                case 10:
                    return base.mostrarCalificacion() + " (Diez)";
                default: return "ERROR";
            }
            
        }
    }
}
