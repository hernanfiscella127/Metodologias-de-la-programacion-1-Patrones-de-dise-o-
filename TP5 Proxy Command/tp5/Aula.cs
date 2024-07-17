using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Aula
    {
        Teacher profe;
        
        public void Comenzar()
        {
            Console.WriteLine("esta comenzando la clase");
            profe = new Teacher();
        }

        public void NuevoAlumno(IAlumno alumno)
        {
            Console.WriteLine("agregando alumno");
            profe.goToClass(new AdaptadorEstudiantes(alumno));
        }

        public void ClaseLista()
        {
            Console.WriteLine("clase lista");
            profe.teachingAClass();
        }
    }
}
