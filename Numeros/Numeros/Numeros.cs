using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Numero
    {
        public int start;
        public int end;

        public Numero(int s, int e)
        {
            start = s;
            end = e;
        }

        public int[] Calcular(bool even, bool odd)
        {
            return Enumerable.Range(start, end - start).Where(n => { if (even) { return n % 2 == 0; } else { return odd ? n % 2 != 0 : false; } }).ToArray();
        }
    }
}
