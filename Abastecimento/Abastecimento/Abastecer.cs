using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abastecimento
{
    class Abastecer
    {
        private double LValue;
        private double paidVal;
        private double disTraveled;

        public Abastecer(double lv, double pv, double td)
        {
            LValue = lv;
            paidVal = pv;
            disTraveled = td;
        }

        public double MediaKmLitro()
        {
            return disTraveled / (paidVal / LValue);
        }

        public double MediaReaisKm()
        {
            return paidVal / disTraveled;
        }
    }
}
