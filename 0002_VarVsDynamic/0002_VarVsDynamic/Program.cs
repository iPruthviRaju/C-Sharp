using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002_VarVsDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //var i; this is not possible since var needs data type
            //i = "string1"; this is not possible
            dynamic j;
            j = 0;
            j = "string2";
        }
    }
}
