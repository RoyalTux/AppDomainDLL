using System;
using System.IO;
using System.Reflection;

namespace AppDomainDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirs = Directory.GetFiles(@"..\..\..\..\AppDomainDLL\AllDll", "*.dll");
            for (int i = 0; i < dirs.Length; i++)
            {
                Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(dirs[i]));
                Type type = assembly.GetType($"ClassLibrary{i + 1}.Class{i + 1}");
                Console.WriteLine("Название DLL: " + type);
                ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
                var MyClass = constructor.Invoke(null);
                //Console.WriteLine(type.GetInterface("IExtension"));
                var res = type.GetInterface("IExtension");
                if (res != null)
                {
                    MethodInfo method = type.GetMethod("GetExtensionName");
                    Console.WriteLine("Содержимое DLL: " + (string)method.Invoke(MyClass, null) + "\n");
                }
                else
                    Console.WriteLine("Нет реализации \"IExtension\" интерфейса\n");
            }
        }
    }
}
