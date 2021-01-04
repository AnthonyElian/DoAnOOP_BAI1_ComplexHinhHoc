using System;
using System.Collections.Generic;
namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Tuple<string, int>>();
            list.Add(Tuple.Create("em yeu", 2));
            Console.WriteLine(list[0].Item1 + " " + list[0].Item2);
        }
    }
}
