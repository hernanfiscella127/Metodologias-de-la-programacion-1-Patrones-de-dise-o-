using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {

        }

        public int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }

    }
}
