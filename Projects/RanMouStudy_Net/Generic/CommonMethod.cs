using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class CommonMethod
    {
        public static void ShowInt(int param)
        {
            Console.WriteLine($"这是{typeof(CommonMethod).Name}, 参数={param.GetType().Name}, value={param}");
        }

        public static void ShowString(string param)
        {
            Console.WriteLine($"这是{typeof(CommonMethod).Name}, 参数={param.GetType().Name}, value={param}");
        }

        public static void ShowObject(object param)
        {
            Console.WriteLine($"这是{typeof(CommonMethod).Name}, 参数={param.GetType().Name}, value={param}");
        }
    }
}
