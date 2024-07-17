using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            aula = a;
        }
      
        public void Ejecutar(Comparable x)
        {

            aula.NuevoAlumno((IAlumno)x);
        }
    }
}
