using System;
using System.Collections.Generic;

namespace tp1
{
    internal class Program {
        private static void numeroRandom(Coleccionable c)
        {
            Random random = new Random();

            for (int i = 0; i < 21; i++)
            {
                c.agregar(new numero(random.Next(1, 20)));
            }
        }
        public static void Informar(Coleccionable c, int opcion)
        {
            Console.WriteLine("Cantidad: " + c.cuantos());
            Console.WriteLine("Minimo: " + c.minimo()); 
            Console.WriteLine("Maximo: " + c.maximo());

            Comparable temp = FabricaDeComparables.crearAleatorio(opcion);
            if (c.contiene(temp))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }

        }

        public static void llenar(Coleccionable e, int opcion)
        {
            for (int i = 1; i < 21; i++)
            {
                Comparable perso = FabricaDeComparables.crearAleatorio(opcion);
                e.agregar(perso);               
            }
        }

        //TP2 Ejercicio 7
        //con este algoritmo de base se trabaja con cualquier iterable/iterador
        public static void cambiarEstrategia(Iterable coleccionable, EstrategiaDeComparacion estrategia)
        {
            Iterador x = coleccionable.crearIterador();
            while (!x.fin())
            {
                Comparable alu = x.actual();
                ((Alumno)alu).setEstrategia(estrategia);
                x.siguiente();
            }
        }
        public static void imprimir(Iterable col)
        {
            Iterador ite = col.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                Comparable elemento = ite.actual();
                Console.WriteLine(elemento);
                ite.siguiente();
            }

        }
        public static void jornadaDeVentas(Coleccionable lista)
        {
            Iterador ite = ((Iterable)lista).crearIterador();
            //for (int i = 0; i == 20; i++)
            //{
                while (ite.fin() != true)
                {
                    var random = new Random();
                    int monto = random.Next(1, 7000);
                    ((Vendedor)ite.actual()).Venta(monto);
                    ((Vendedor)ite.actual()).notificar();

                    ite.siguiente();
                }
            //}
        }
        public static void agregargerente(Coleccionable coleccion, Gerente gerente)
        {

            Iterador a = ((Iterable)coleccion).crearIterador();

            while (a.fin() != true)
            {
                ((Vendedor)a.actual()).agregarObservador(gerente);

                a.siguiente();

            }

        }
        public static void agregarObservadores(Iterable c, IObservador o)
        {
            Iterador x = c.crearIterador();
            while (!x.fin())
            {
                Vendedor v = (Vendedor)x.actual();
                v.agregarObservador(o);
                x.siguiente();
            }
        }
        public static void imprimirElementos(Iterable c)
        {
            Iterador x = c.crearIterador();
            while (!x.fin())
            {
                Console.Write(x.actual() + " ");
                x.siguiente();
            }
        }
        static void Main(string[] args)
        {

            Aula aula = new Aula();
            OrdenInicio inicio = new OrdenInicio(aula);
            OrdenAulaLlena lleno = new OrdenAulaLlena(aula);
            OrdenLlegaAlumno alumno = new OrdenLlegaAlumno(aula);

            Pila pila = new Pila();
            pila.setOrdenInicio(inicio);
            pila.setOrdenAulaLlena(lleno);
            pila.setOrdenLlegaAlumno(alumno);

            llenar(pila, 3);
            llenar(pila, 4);

            Console.ReadKey(true);
        }
    }    
}

