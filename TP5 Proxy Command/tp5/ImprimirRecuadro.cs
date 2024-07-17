using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class ImprimirRecuadro: Decorador
    {
        public ImprimirRecuadro(IAlumno a) : base(a)
        {


        }
        public override string mostrarCalificacion()
        {
      

            return "*********************************************************************\n " + "*       "+ base.mostrarCalificacion() 
                + "            *\n" + "*********************************************************************";
        }

       
    }
}
