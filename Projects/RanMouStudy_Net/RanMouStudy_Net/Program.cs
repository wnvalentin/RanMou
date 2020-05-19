using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;
using System.Configuration;
using System.Reflection;
using Reflection;

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
            //ShowAllExceptions.Go();

            Console.WriteLine();
            Console.WriteLine("------------通过反射调用方法-------------");
            var assembly = Assembly.Load("Reflection");
            var type = assembly.GetType("Reflection.ReflectionTest");
            object oReflTest = Activator.CreateInstance(type);
            {
                MethodInfo mi = type.GetMethod("Show1");
                mi.Invoke(oReflTest, null);
            }
            {
                MethodInfo mi = type.GetMethod("Show2");
                mi.Invoke(oReflTest, new object[] { 123 });
            }
            {
                MethodInfo mi = type.GetMethod("Show5");
                mi.Invoke(oReflTest, new object[] { "哈哈" });
                mi.Invoke(null, new object[] { "哈哈" });
            }
            {
                MethodInfo mi = type.GetMethod("Show3", new Type[] { typeof(int), typeof(string) });
                mi.Invoke(oReflTest, new object[] { 123, "2345" });
                mi = type.GetMethod("Show3", new Type[] { });
                mi.Invoke(oReflTest, null);
            }
            {
                //MethodInfo mi = type.GetMethod("Show4", BindingFlags.NonPublic|BindingFlags.Instance);
                //mi.Invoke(oReflTest, null);
                var mis = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
                var mi2 = mis.FirstOrDefault(m => m.GetParameters().FirstOrDefault().ParameterType == typeof(string));
                mi2.Invoke(oReflTest, new object[] { "2345" });
            }

            Console.WriteLine();
            Console.WriteLine("------------通过反射调用泛型方法-------------");
            assembly = Assembly.Load("Reflection");
            Type typeOpen = assembly.GetType("Reflection.GenericDouble`1");
            Type typeClosed = typeOpen.MakeGenericType(new Type[] { typeof(int) });
            object oGenRefl = Activator.CreateInstance(typeClosed);
            {
                MethodInfo mi = typeClosed.GetMethod("Show");
                MethodInfo mi2 = mi.MakeGenericMethod(new Type[] { typeof(string), typeof(DateTime) });
                mi2.Invoke(oGenRefl, new object[] { 12, "12", DateTime.Now });
            }


            Console.ReadKey();
        }
    }




    
}
