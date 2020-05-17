using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RanMouStudy_Net
{
    static class ShowAllExceptions
    {
        public static void Go()
        {
            //显式加载要反射的程序集
            LoadAssemblies();

            //对所有类型进行筛选和排序
            var allTypes =
                (from a in AppDomain.CurrentDomain.GetAssemblies()
                 from t in a.ExportedTypes
                 where typeof(Exception).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo())
                 orderby t.Name
                 select t
                 ).ToArray();
            //生成并显示继承层级结构
            Console.WriteLine(WalkInheritanceHierarchy(new StringBuilder(), 0, typeof(Exception), allTypes));

        }

        private static StringBuilder WalkInheritanceHierarchy(StringBuilder sb, int indent, Type baseType, IEnumerable<Type> allTypes)
        {
            string spaces = new String(' ', indent * 3);
            sb.AppendLine(spaces + baseType.FullName);
            foreach(var t in allTypes)
            {
                if (t.GetTypeInfo().BaseType != baseType)
                    continue;
                WalkInheritanceHierarchy(sb, indent + 1, t, allTypes);
            }
            return sb;
        }

        private static void LoadAssemblies()
        {
            string[] assemblies =
            {
                "System,                        PublicKeyToken={0}",
                "System.Core,                   PublicKeyToken={0}",
                "System.Data,                   PublicKeyToken={0}",
                "System.Design,                 PublicKeyToken={1}",
                "System.DirectoryServices,      PublicKeyToken={1}",
                "System.Drawing,                PublicKeyToken={1}",
                "System.Drawing.Design,         PublicKeyToken={1}",
                "System.Management,             PublicKeyToken={1}",
                "System.Messaging,              PublicKeyToken={1}",
                "System.Runtime.Remoting,       PublicKeyToken={0}",
                "System.Security,               PublicKeyToken={1}",
                "System.ServiceProcess,         PublicKeyToken={1}",
                "System.Web,                    PublicKeyToken={1}",
                "system.Web.RegularExpressions, PublicKeyToken={1}",
                "System.Web.Services,           PublicKeyToken={1}",
                "System.Xml,                    PublicKeyToken={0}"
            };
            string EcmaPublicKeyToken = "b77a5c561934e089";
            string MSPublicKeyToken = "b03f5f7f11d50a3a";

            //获取包含System.Object的程序集的版本
            //假定其他所有程序集都是相同的版本
            Version version = typeof(System.Object).Assembly.GetName().Version;

            //显式加载要反射的程序集
            foreach(var a in assemblies)
            {
                string assembIdentity = string.Format(a, EcmaPublicKeyToken, MSPublicKeyToken) + 
                    ", Culture=neutral, Version=" + version;
                Assembly.Load(assembIdentity);
            }
        }
    }
}
