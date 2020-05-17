using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;

namespace RanMouStudy_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("------------泛型类型-------------");
            Console.WriteLine(typeof(List<int>));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<string>));

            Object o;
            o = Activator.CreateInstance(typeof(List<int>));
            var t = o.GetType();
            Console.WriteLine(t.GetType().FullName);
            //o = Activator.CreateInstance(typeof(List<>));

            Console.WriteLine();
            Console.WriteLine("------------打印Exception类-------------");
            ShowAllExceptions.Go();

            Console.ReadKey();
        }
    }




    
}
