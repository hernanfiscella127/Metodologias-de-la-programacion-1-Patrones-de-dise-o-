using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetNombre() == ((IAlumno)x).GetNombre())
            {
                return true;
            }
            else return false;
        }
        public bool sosMayor(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetNombre().Length > ((IAlumno)x).GetNombre().Length)
            {
                return true;
            }
            else return false;
        }
        public bool sosMenor(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetNombre().Length < ((IAlumno)x).GetNombre().Length)
            {
                return true;
            }
            else return false;
        }
    }
}
