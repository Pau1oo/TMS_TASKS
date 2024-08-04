using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
        where T : IComparable<T>
        where U : IComparable<U>
    {
        public T t_value;
        public U u_value;

        public T T_Value 
        {   
            get { return t_value; } 
            set { t_value = value; }
        }
        public U U_Value 
        { 
            get { return u_value; } 
            set { u_value = value; } 
        }

        public ComparablePair(T T_Value, U U_Value)
        {
            t_value = T_Value;
            u_value = U_Value;
        }

        public int CompareTo(ComparablePair<T, U> other)
        {
            if (other == null)
                return 1;

            int tComparison = t_value.CompareTo(other.t_value);
            if (tComparison != 0)
                return tComparison;

            return u_value.CompareTo(other.u_value);
        }
    }
}
