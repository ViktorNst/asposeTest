using System;
using System.Collections.Generic;

namespace AsposeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringToKeypadConverter converter = new StringToKeypadConverter();
            List<string> strings = new List<string>();

            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                strings.Add(Console.ReadLine());
            }

            for (int i = 0; i < strings.Count; i++)
            {
                string convertedValue = converter.convertToKeyPad(strings[i]);
                Console.WriteLine($"Case #{i+1}: {convertedValue}");
            }
        }
    }
}
