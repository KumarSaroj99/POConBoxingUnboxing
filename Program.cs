using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine("The number is : "+number);

            object obj = "Hello";
            Console.WriteLine("Object contains : "+obj);
            //value type --> reference
            obj = number;
            Console.WriteLine("Now the object contains : "+obj+ " ," +
                "after value type --> reference casting.");
            //reference --> value type
            number = (int)obj;
            Console.WriteLine("Now the number contains : " + obj + " ," +
                "after reference --> value type casting.");
        }
    }
}
