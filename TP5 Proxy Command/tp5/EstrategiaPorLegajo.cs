using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class EstrategiaPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetLegajo() == ((IAlumno)x).GetLegajo())
            {
                return true;
            }
            else return false;
        }
        public bool sosMayor(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetLegajo() > ((IAlumno)x).GetLegajo())
            {
                return true;
            }
            else return false;
        }
        public bool sosMenor(Comparable c, Comparable x)
        {
            if (((IAlumno)c).GetLegajo() < ((IAlumno)x).GetLegajo())
            {
                return true;
            }
            else return false;

        }
    }
}
