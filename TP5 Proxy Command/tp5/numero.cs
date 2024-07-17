using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class numero : Comparable
    {
        int valor;
        public numero(int n)
        {
            valor = n;
        }
        public int getValor()
        {
            return valor;
        }
        public override string ToString()
        {
            return this.getValor().ToString(); //en este caso el valor es un entero y tenemos que devolver siempre un string
        }
        public bool sosIgual(Comparable c)
        {  //usa la propiedad get para poder usar el valor de la variable int valor y compararlo y el this. para poder llamarlo
            return this.getValor() == ((numero)c).getValor(); // hace falta castear ya que comparable no tiene ese metodo, se castea a numero porque se estan comparando numeros esa no falla
        }
        public bool sosMayor(Comparable c)
        {
            return this.getValor() > ((numero)c).getValor();
        }
        public bool sosMenor(Comparable c)
        {
            return this.getValor() < ((numero)c).getValor();
        }

    }
}
