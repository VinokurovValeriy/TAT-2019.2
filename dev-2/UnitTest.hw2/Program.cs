using System;

namespace UnitTest.hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringAnalizer.MaxCountOfDifferentSymbols("weretryфвмфвм"));
            Console.WriteLine(StringAnalizer.MaxCountOfIdenticalDigits("222244wbfdeeeeeeeeee32"));
            Console.WriteLine(StringAnalizer.MaxCountOfIdenticalLatinSymbols("yvbuhninnnnn"));
        }
    }
}