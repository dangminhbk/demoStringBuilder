using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pro1
{
    [Description("String concat with for loop and +")]
    class String
    {
        static void Main()
        {
            var data = GeneratedData.data;
            var s = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var item in data)
            {
                s = s + item;
            }
            watch.Stop();
            Console.WriteLine("time:" + watch.ElapsedMilliseconds);
        }
    }
}
