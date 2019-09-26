using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int result = 0;
            int count = 1;

            Console.WriteLine("Write text ");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length - 1; i++)
            {

                if (text[i] == text[i + 1])
                {
                    count++;
                    if (result < count)
                    {
                        result = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}

