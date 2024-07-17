using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Cola : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementos;
        public Cola()
        {
            elementos = new List<Comparable>();
        }
        public Comparable elemento(int a)
        {
            return (Comparable)elementos[a];
        }
        public void enqueue(Comparable n)
        {
            elementos.Add(n);
        }
        public Comparable dequeue()
        {
            Comparable n = elementos[0];
            elementos.RemoveAt(0);
            return n;
        }
        public bool isEmpty()
        {
            return elementos.Count == 0;
        }
        public int size()
        {
            return elementos.Count;
        }
        public Comparable front()
        {
            return elementos[0];
        }
        public int cuantos()
        {
            return elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable bajo = elementos[0];
            foreach (Comparable i in elementos)
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
            Comparable alto = elementos[0];
            //yo del futuro:es lo mismo que el minimo ahora lo hago con for para cambiar un poco nomas
            for (int i = 1; i < this.size(); i++)//arranca del 1 porque el lugar 0 ya esta asignado asi que da igual
            {
                if (elementos[i].sosMayor(alto))
                {
                    alto = elementos[i];
                }
            }
            return alto;
        }
        public void agregar(Comparable c)
        {
            //this.enqueue(c); //el push era el agregar de la cola
            elementos.Add(c);

            if (elementos.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)c);

            if (elementos.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();
        }
        public bool contiene(Comparable c)
        {
            foreach (Comparable i in elementos)
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
            return new IteradorLista(elementos);
        }
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula1 ordenAulaLlena = null;
        OrdenEnAula2 ordenLlegaAlumno = null;

        public void setOrdenInicio(OrdenEnAula1 orden1)
        {
            ordenInicio = orden1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden2)
        {
            ordenLlegaAlumno = orden2;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden1)
        {
            ordenAulaLlena = orden1;
        }
    }
}
