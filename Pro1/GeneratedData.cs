using System;
using System.Collections.Generic;
using System.Text;

namespace Pro1
{
    public static class GeneratedData
    {
        private static List<string> _data;
        public static List<string> data
        {
            get
            {
                if(_data==null)
                {
                    _data = new List<string>();
                    for (int i = 0; i < 10000; i++)
                    {
                        _data.Add("lorem ipsum");
                    }
                }
                return _data;
            }

        }
    }
}
