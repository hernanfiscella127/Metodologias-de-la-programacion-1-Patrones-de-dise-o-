using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class ColeccionMultiple :Coleccionable
    {
        Pila pila;
        Cola cola;
        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }
        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }
        public Comparable minimo()
        {
            Comparable p = pila.minimo();
            Comparable c = cola.minimo();
            if (p.sosMenor(c))
            {
                return p;
            }
            else
            {
                return c;
            }
        }
        public Comparable maximo()
        {
            Comparable p = pila.maximo();
            Comparable c = cola.maximo();

            if (p.sosMayor(c))
            {
                return p;
            }
            else
            {
                return c;
            }
        }
        public void agregar(Comparable c)
        {
            // no lleva nada 
        }
        public bool contiene(Comparable c)
        {
            if (pila.contiene(c) ||  cola.contiene(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
