using System;
using System.IO;
using System.Collections.Generic;
using SelfDescribingNumbers;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            ISelfDescribingFinder finder = new SimpleSelfDescribingNumberfinder();

            Console.WriteLine(finder.Test(int.Parse(line)) ? 1 : 0);
        }
    }
}