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
            CommonMethod.ShowInt(9);
            CommonMethod.ShowString("haha");
            CommonMethod.ShowObject(8);
            CommonMethod.ShowObject(new int[] { 0, 1 });
            Console.WriteLine();

            Console.WriteLine(typeof(List<int>));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<string>));

            GenericMethod.Show<int>(7);
            Console.WriteLine();


            ArrayList al = new ArrayList();



            Console.ReadKey();
        }
    }




    
}
