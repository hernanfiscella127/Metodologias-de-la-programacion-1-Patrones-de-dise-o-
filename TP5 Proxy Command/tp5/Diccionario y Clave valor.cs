using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Diccionario : Coleccionable , Ordenable
    {
        int Contador = 0;
        Conjunto conjunto = new Conjunto();
        public bool contiene(Comparable n)
        {
            return conjunto.contiene(n);
        }

        public Comparable elemento(int a)
        {
            return conjunto.elemento(a);
        }

        public Coleccionable ConjuntoDeDiccionario()
        {
            return conjunto;

        }
        public int cuantos()
        {
            return conjunto.cuantos();
        }

        public Comparable maximo()
        {
            return conjunto.maximo();
        }

        public Comparable minimo()
        {
            return conjunto.minimo();
        }

        public void agregar(Comparable va)
        {
            Contador++;
            Comparable clave = new numero(Contador);
            Comparable clavevalor = new ClaveValor(clave, va);
            conjunto.agregar(clavevalor);

        }

        public Comparable ValorDe(Comparable cla)
        {
            return conjunto.valorde(cla);
        }

        /*public IteradorColleccionable crearIterador()
        {


            return new IteradorDiccionario(this);


        }*/
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
    class ClaveValor : Comparable

    {
        Comparable clave;
        Comparable Valor;

        public ClaveValor(Comparable cla,Comparable val)
        {
            this.clave = cla;
            this.Valor = val;
        }
        public void agregarvalor(Comparable a)
        {
            this.Valor = a;
        }
        public void agregarclave(Comparable a)
        {
            this.clave = a;

        }
        public Comparable setvalor()
        {
            return Valor;
        }
        public Comparable setclave()
        {
            return clave;
        }

        public bool sosIgual(Comparable n)
        {
            if ((((numero)Valor).sosIgual(((ClaveValor)n).setvalor())))                
            {
                return true;
            }
            return false;
        }

        public bool sosMenor(Comparable n)
        {

            if (((numero)Valor).sosMenor(((ClaveValor)n).setvalor()))
            {
                return true;
            }
            return false;
        }
        public bool sosMayor(Comparable n)
        {
            if (((numero)Valor).sosMayor(((ClaveValor)n).setvalor()))
            {
                return true;
            }
            return false;

        }

    }

}
