using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;

namespace _Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            var data = GenerationData(15000000);
            timer.Stop();
            timer.Start();
            data.Cast<string>()
                .GroupBy(x => x)
                .OrderBy(x => x.LongCount())
                .ToList()
                .ForEach(x => Console.WriteLine("Key: {0}, Count: {1}", x.Key, x.LongCount()));
            timer.Stop();
            Console.ReadLine();
        }

        public static StringCollection GenerationData(int count)
        {
            var random = new Random();
            var result = new StringCollection();
            for (var i = 0; i < count; i++)
                result.Add(Convert.ToString(random.Next(0, 1000)));
            return result;
        }
    }
}