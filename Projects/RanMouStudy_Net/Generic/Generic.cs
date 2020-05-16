using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Generic<T> where T : struct
    {
        public T T_;

        public string GetTInfo()
        {
            return typeof(T).FullName;
        }
    }

    public class ChildGeneric<T> : Generic<T> where T : struct
    {

    }


    public interface IGeneric2
    {
        string GetTInfo<T>() where T : struct;
    }

    internal class ChildGeneric
    {

        public string GetTInfo<T>(T o1, T o2) where T : class
        {
            if (o1 == o2)
            {

            }
            return "";
        }
    }
}
