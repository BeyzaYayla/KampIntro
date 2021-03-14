using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();
            myDict.Add(1234, "Beyza Yayla");
            Console.WriteLine(myDict.Count);
        }
    }
}
