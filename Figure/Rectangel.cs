using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Rectangel : Figure
    {
        public double radiys;

        public override double getPerimetr()
        {
            return radiys * 2 * Pichislo;
        }

        //реализуем абстрактный метод
        //public override double getSqare()
        //{
        //    return radiys * radiys * 3.14;
        //}

        public override double getSqare()
        {
            return radiys * radiys * Pichislo;
        }
    }
}
