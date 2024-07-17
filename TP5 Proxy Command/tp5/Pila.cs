using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Pila : Coleccionable, Iterable , Ordenable
    {
        private List<Comparable> lista;
        public Pila()
        {
            lista = new List<Comparable>();
        }
        public Comparable elemento(int a)
        {
            return (Comparable)lista[a];
        }
        public void push(Comparable n)
        {
            lista.Add(n);
            if (lista.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)n);

            if (lista.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
        }
        public Comparable pop()
        {
            Comparable n = lista[lista.Count - 1];
            lista.RemoveAt(lista.Count - 1);
            return n;
        }
        public bool isEmpty()
        {
            return lista.Count == 0;
        }
        public int size()
        {
            return lista.Count;
        }
        public Comparable top()
        {
            return lista[lista.Count - 1];
        }
        public int cuantos()
        {
            return lista.Count;
        }
        public Comparable minimo()
        {
            Comparable bajo = lista[0];
            foreach (Comparable i in lista)
            {
                //if(i < bajo) // entre comparable no se puede usar asi que hay que usar otra forma
                //{
                // i = bajo;
                //return i;
                //}

                if (i.sosMenor(bajo)) //ahi si funciona con cualquier elemento
                {
                    bajo = i;
                }
            }
            return bajo;
        }
        public Comparable maximo()
        {
            Comparable alto = lista[0];
            //yo del futuro:es lo mismo que el minimo ahora lo hago con for para cambiar un poco nomas
            for (int i = 1; i < this.cuantos(); i++)//arranca del 1 porque el lugar 0 ya esta asignado asi que da igual
            {
                if (lista[i].sosMayor(alto))
                {
                    alto = lista[i];
                }
            }
            return alto;
        }
        public void agregar(Comparable c)
        {
            this.push(c); //el push era el agregar de la cola
        }
        public bool contiene(Comparable c)
        {
            foreach (Comparable i in lista)
            {
                if (i.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public Iterador crearIterador()
        {
            return new IteradorLista(lista);
        }//
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula1 ordenAulaLlena = null;
        OrdenEnAula2 ordenLlegaAlumno = null;

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }
    }
}
