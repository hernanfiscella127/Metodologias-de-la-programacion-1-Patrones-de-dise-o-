using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{   //IAalumno es la interface de componentes de decorator
    public interface IAlumno : Comparable // el comparable es para solucionar un problema de casteo 
    {
        int GetCalificacion();
        void SetCalificacion(int nota);
        int ResponderPregunta(int respuesta);
        string mostrarCalificacion();
        int GetLegajo();
        int GetPromedio();
        string GetNombre();
        int GetDni();
    }
}
