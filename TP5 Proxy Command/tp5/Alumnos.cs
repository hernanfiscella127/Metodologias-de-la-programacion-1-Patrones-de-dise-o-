using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Alumno : Persona , IAlumno
    {
        int legajo;
        int promedio;
        //strategi:PASO 3:
        //Comienzo strategi paso 3 : paso 3.1 crear la composicion
        private EstrategiaDeComparacion estrategia;
        int calificacion;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new EstrategiaPorPromedio(); //3.2 = establecer una estrategia por defecto
        }
        
        //strategi:paso 3.3 mecanismo para cambiar estrategias
        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }
        public override String ToString()
        {

            return "Nombre: " + GetNombre() + " Dni: " + GetDni() + " Legajo: " + legajo + " Promedio: " + promedio + " estrategia: " + estrategia;


        }
        public int GetCalificacion()
        {
            return calificacion;
        }
        public void SetCalificacion(int opcion)
        {
            calificacion = opcion;
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            Random x = new Random();
            var i = x.Next(1, 3);
            return i;
        }
        public string mostrarCalificacion() // es la parte de alumno que hay que decorar con decorator nombre y calificacion seria lo base y a eso se le va agregando
        {
            return this.GetNombre() + this.calificacion;
        }

        public int GetLegajo()
        {
            return legajo;
        }

        public int GetPromedio()
        {
            return promedio;
        }
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c);
        }
        public  override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);

        }

    }
}
