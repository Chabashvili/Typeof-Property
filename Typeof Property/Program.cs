using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Typeof_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(MyClass);
            object instance = Activator.CreateInstance(myType);

            PropertyInfo prop1 = myType.GetProperty("MyProperty1");
            PropertyInfo prop2 = myType.GetProperty("MyProperty2");

            prop1.SetValue(instance, 42);
            prop2.SetValue(instance, "Hello, Reflection!");

            Console.WriteLine("MyProperty1 Value: " + prop1.GetValue(instance));
            Console.WriteLine("MyProperty2 Value: " + prop2.GetValue(instance));
        }
        public class MyClass
        {
            public int MyProperty1 { get; set; }
            public string MyProperty2 { get; set; }
        }
    }
}
