using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Persona : Comparable
    {
        string nombre;
        int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Persona(int dni)
        {
            this.dni = dni;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetDni()
        {
             return dni; 
        }
        public virtual bool sosIgual(Comparable c)
        {
            //si coparara en lugar de por dni por otro tipo pj el string hay que usar el compareTo() ya que los ==, <, > nadamas funcionan con enteros
            return this.dni == ((Persona)c).dni;
        }
        public virtual bool sosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).dni;
        }
        public virtual bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).dni;
        }
        public override String ToString()
        {
            return "valor igual a: " + dni;
        }
    }
}
