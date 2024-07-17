using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    internal class IteradorLista : Iterador
    {
        private List<Comparable> elementos;
        private int indice;
        public IteradorLista(List<Comparable> e)
        {
            this.elementos = e;
            indice = elementos.Count - 1;
        }
        public void primero()
        {
            indice = elementos.Count - 1;
        }
        public void siguiente()
        {
            indice--;
        }
        public bool fin()
        {
            return indice < 0;
        }
        public Comparable actual()
        {
            return elementos[indice];
        }
    }
}
