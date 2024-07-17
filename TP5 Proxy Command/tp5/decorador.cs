using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    abstract class Decorador : IAlumno
    {
        IAlumno deco;


        public Decorador(IAlumno a)
        {
            deco = a;
        }
        public int GetCalificacion()
        {
            return deco.GetCalificacion();
        }

        public int GetDni()
        {
            return deco.GetDni();
        }

        public int GetLegajo()
        {
            return deco.GetLegajo();
        }

        public string GetNombre()
        {
            return deco.GetNombre();
        }

        public int GetPromedio()
        {
            return deco.GetPromedio();
        }

        public virtual string mostrarCalificacion()
        {
            return deco.mostrarCalificacion();
        }

        public int ResponderPregunta(int pregunta)
        {
            return deco.ResponderPregunta(pregunta);
        }

        public void SetCalificacion(int nota)
        {
            deco.SetCalificacion(nota);
        }

        public bool sosIgual(Comparable n)
        {
            return deco.sosIgual(n);
        }

        public bool sosMayor(Comparable n)
        {
            return deco.sosMayor(n);
        }

        public bool sosMenor(Comparable n)
        {
            return deco.sosMenor(n);
        }
    }
}
