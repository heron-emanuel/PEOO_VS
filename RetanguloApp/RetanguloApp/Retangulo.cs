using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloApp
{
    class Retangulo
    {
        public double m_base;
        public double m_height;

        public Retangulo(double b, double h)
        {
            m_base = b;
            m_height = h;
        }
        
        public double CalcArea()
        {
            return m_base * m_height;
        }

        public double CalcDiagonal()
        {
            return Math.Sqrt(m_height*m_height + m_base*m_base);
        }
         
    }
}
