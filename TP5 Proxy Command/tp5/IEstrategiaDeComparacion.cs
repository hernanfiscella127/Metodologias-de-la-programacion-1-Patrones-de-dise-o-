using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public interface EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2);
        public bool sosMenor(Comparable c1, Comparable c2);
        public bool sosMayor(Comparable c1, Comparable c2);
    }
}
