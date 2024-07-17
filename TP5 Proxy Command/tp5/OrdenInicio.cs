using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula a)
        {
            aula = a;
        }
        public void Ejecutar()
        {
            aula.Comenzar();
        }
    }
}
