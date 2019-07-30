using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Pro1
{
    [Description("String concat with aggregate")]
    class StringWithAggregate
    {
        static void Main()
        {
            var data = GeneratedData.data;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var s = data.Aggregate("",(sum, item)=> sum+item);
            watch.Stop();
            Console.WriteLine("time:" + watch.ElapsedMilliseconds);
        }
    }
}
