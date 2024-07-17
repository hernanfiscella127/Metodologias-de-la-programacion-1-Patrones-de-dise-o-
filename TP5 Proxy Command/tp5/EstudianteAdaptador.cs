using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class AdaptadorEstudiantes : Student  //siempre hereda del objetivo que va a traducir
    {
        private IAlumno alumno; //probar despues si en lugar de usar la interface si usando Alumno directamente funciona igual 

        public IAlumno getalumno()
        {
            return alumno;
        }

        public AdaptadorEstudiantes(IAlumno a)
        {
            alumno = a;
        }
        public bool equals(Student student)
        {
            return alumno.sosIgual(((AdaptadorEstudiantes)student).getalumno());
        }

        public string getName()
        {
            return alumno.GetNombre();
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AdaptadorEstudiantes)student).getalumno());
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AdaptadorEstudiantes)student).getalumno());
        }

        public void setScore(int score)
        {
            alumno.SetCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.ResponderPregunta(question);
        }

    }
}

