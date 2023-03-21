using System;
using MyCollection;

namespace Lab13_PSTU_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            var x =new MyCollection<string>();
            x.Add("hello1");
            x.Add("hello2");
            x.Add("hello3");
            x.Add("hello4");
            Console.WriteLine(x);
        }
    }
}
