using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public interface Comparable
    {
        bool sosIgual(Comparable c);
        bool sosMayor(Comparable c);
        bool sosMenor(Comparable c);
    }
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo(); // es de tipo comparable es porque tiene que ser capas de comparar sea cual sea el tipo ( siempre y cuando lo comparado sea del mismo tipo)
        Comparable maximo(); // tambien devuelve un comparable
        void agregar(Comparable c);
        bool contiene(Comparable c);
    }
    //clase 2: iterador
    //Iterator: Paso 1 ; interface Iterador
    public interface Iterador //lo implementa la clase que va a hacer el recorrido de PJ una cola, una lista que puede ser de cualquier tipo, etc.
    {
        //tiene que tener 4 metodos
        void primero(); // te permite colocarte en el primer elemento del agregado
        void siguiente(); // te permite avanzar al siguiente elemento del agregado
        bool fin(); // que te permita saber si ya recorriste todos los elementos del agregado
        Comparable actual(); // que te permita devolver un elemento del agregado
    } 
    //Iterator: paso 2 implementar un iterador en concreto para lo que queres recorrer pj un pila, es como estrategy segun lo que quieras hacer se hace una clase para eso
    //_una forma es hacerlo asi, lo unico que tendria que hacer pj si queres recorrer una cola en lugar de pila seria cambiar las variables de tipo Pila por Cola(forma menos eficiente)
    //_otra forma es aprovechar que ya sea pila o cola se van a almacenar en una lista de comparables ( implementado en clase pilaIterador)


    //Iterador:Paso 3: crear una interface iterable
    public interface Iterable //lo implementa el agregados
    {
        //tiene un unico metodo que crea el itetador y lo devuelve
        Iterador crearIterador();
        //El paso 4 es que los agregados lo implementen PJ Pila, Cola ,etc.
    }
    //Paso 5: usar los iterables(cliente)


    //Observer:
    public interface IObservador // la lleva el que va a observar
    {
        void actualizar(IObservado i); // para los que estan obsevando se enteren del cambio
    }

    public interface IObservado // el que es obsevado implementa esos metodos
    {
        void agregarObservador(IObservador i); // empezar a mirar
        void quitarObservador(IObservador i); // dejar de mirar
        void notificar(); // notifica si pasa algo
    }

}

