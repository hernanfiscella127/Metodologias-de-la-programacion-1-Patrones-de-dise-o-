using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp1
{
    class Conjunto : Coleccionable, Iterable, Ordenable
    {
        private ArrayList ListaConjunto = new ArrayList();
        public Iterador crearIterador()
        {
            return new IteradorConjuntos(this);
        }

        public Comparable elemento(int a)
        {
            int menos = a - 1;
            return (Comparable)ListaConjunto[menos];
        }
        public int cuantos()
        {
            return ListaConjunto.Count;
        }

        public Comparable maximo()
        {
            Comparable maximo = null;

            foreach (Comparable valoractual in ListaConjunto)
            {

                if (maximo == null)
                {
                    maximo = valoractual;
                }

                if (maximo.sosMayor(valoractual))
                {

                }
                else
                {
                    maximo = valoractual;
                }
            }
            return maximo;

        }

        public Comparable minimo()
        {
            Comparable minimo = null;

            foreach (Comparable valoractual in ListaConjunto)
            {
                if (minimo == null)
                {
                    minimo = valoractual;
                }

                if (minimo.sosMenor(valoractual))
                {

                }
                else
                {

                    minimo = valoractual;
                }
            }
            return minimo;

        }

        public bool contiene(Comparable elemento)
        {
            foreach (Comparable a in ListaConjunto)
            {
                if (a.sosIgual(elemento) == true)
                {
                    return true;

                }
            }
            return false;
        }
        public void agregar(Comparable elemento)
        {
            if (ListaConjunto.Count == 1)
                if (ordenInicio != null)
                    ordenInicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar((IAlumno)elemento);

            if (ListaConjunto.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();

            if (contiene(elemento))
            {
                Console.WriteLine("el elemento ya existe ");
            }
            else
            {
                ListaConjunto.Add(elemento);
            }
        }
        public Comparable valorde(Comparable cla)
        {
            foreach (Comparable o in ListaConjunto)
            {
                if (((ClaveValor)o).setclave() == cla)
                {
                    return o;

                }
            }
            return null;
        }
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
