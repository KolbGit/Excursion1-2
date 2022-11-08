using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Circle : Figure
    {
        public double radiys;

        public override double getPerimetr()
        {
            return radiys * 2 * Pichislo;
        }

        //реализуем абстрактный метод
        public override double getSqare()
        {
            return radiys * radiys * Pichislo;
        }
    }
}
