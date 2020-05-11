using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericMethod
    {
        //public T MyProperty { get; set; }

        public static void Show<T>(T param)
        {
            Console.WriteLine($"这是{typeof(GenericMethod).Name}, 参数={param.GetType().Name}, value={param}");
        }
    }
}
