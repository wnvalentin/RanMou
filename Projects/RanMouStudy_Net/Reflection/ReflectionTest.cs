using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ReflectionTest
    {
        #region ctor
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public ReflectionTest()
        {
            Console.WriteLine("调用了{0}无参数构造函数", this.GetType());
        }

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="name"></param>
        public ReflectionTest(string name)
        {
            Console.WriteLine("调用了{0} 有参数构造函数(string)", this.GetType());
        }

        public ReflectionTest(int id)
        {
            Console.WriteLine("调用了{0} 有参数构造函数(int)", this.GetType());
        }
        #endregion

        #region Method
        /// <summary>
        /// 无参方法
        /// </summary>
        public void Show1()
        {
            Console.WriteLine("调用了{0}的Show1()", this.GetType());
        }

        /// <summary>
        /// 有参数方法
        /// </summary>
        /// <param name="id"></param>
        public void Show2(int id)
        {

            Console.WriteLine("调用了{0}的Show2(int)", this.GetType());
        }

        /// <summary>
        /// 重载方法之一
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void Show3(int id, string name)
        {
            Console.WriteLine("调用了{0}的Show3(int, string)", this.GetType());
        }

        /// <summary>
        /// 重载方法之二
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public void Show3(string name, int id)
        {
            Console.WriteLine("调用了{0}的Show3(string, int)", this.GetType());
        }

        /// <summary>
        /// 重载方法之三
        /// </summary>
        /// <param name="id"></param>
        public void Show3(int id)
        {

            Console.WriteLine("调用了{0}的Show3(int)", this.GetType());
        }

        /// <summary>
        /// 重载方法之四
        /// </summary>
        /// <param name="name"></param>
        public void Show3(string name)
        {

            Console.WriteLine("调用了{0}的Show3(string)", this.GetType());
        }

        /// <summary>
        /// 重载方法之五
        /// </summary>
        public void Show3()
        {

            Console.WriteLine("调用了{0}的Show3()", this.GetType());
        }

        /// <summary>
        /// 私有方法
        /// </summary>
        /// <param name="name"></param>
        private void Show4(string name)
        {
            Console.WriteLine("调用了{0}的私有Show4(string)", this.GetType());
        }
        private void Show4(int name)
        {
            Console.WriteLine("调用了{0}的私有Show4(int)", this.GetType());
        }
        private void Show4()
        {
            Console.WriteLine("调用了{0}的私有Show4()", this.GetType());
        }

        /// <summary>
        /// 静态方法
        /// </summary>
        /// <param name="name"></param>
        public static void Show5(string name)
        {
            Console.WriteLine("调用了{0}的静态Show5(string)", typeof(ReflectionTest));
        }

        #endregion
    }
}
