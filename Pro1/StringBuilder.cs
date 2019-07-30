using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pro1
{
    [Description("String concat string builder and append")]
    class StringBuilder
    {
        static void Main()
        {
            var data = GeneratedData.data;
            var s = new System.Text.StringBuilder();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var item in data)
            {
                s.Append(item);
            }
            watch.Stop();
            Console.WriteLine("time:" + watch.ElapsedMilliseconds);
        }
    }
}
