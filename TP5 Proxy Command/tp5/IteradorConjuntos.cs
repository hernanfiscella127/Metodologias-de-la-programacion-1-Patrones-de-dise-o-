using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class IteradorConjuntos:Iterador
    {
        Conjunto conjunto;            
        int indice;

        public IteradorConjuntos (Iterable s)
        {
            this.conjunto = (Conjunto)s;
            this.indice = 0;
        }

        public Comparable actual()
        {
            return conjunto.elemento(indice);
        }
        public bool fin()
        {
            if (conjunto.cuantos() == indice + 1)
            {

                return true;
            }
            else return false;
        }

        public void primero()
        {
            conjunto.elemento(0);
        }

        public void siguiente()
        {
            indice++;
        }
    }
}
