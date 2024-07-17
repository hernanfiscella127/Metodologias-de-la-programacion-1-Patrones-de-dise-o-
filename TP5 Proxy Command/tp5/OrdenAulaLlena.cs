using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class OrdenAulaLlena: OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            aula = a;
        }
        public void Ejecutar()
        {
            aula.ClaseLista();
        }
    }
}
