using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Figure
{
    abstract class Figure
    {
        string name;
        string colorFigure;
        private const double Pi = 3.14;

        public string Name { get; set; }
        public string ColorFigure { get; set; }
        public double Pichislo { get { return Pi; } }

        public abstract double getSqare();

        public abstract double getPerimetr();

        public double Otnoshenie(double s, double p)
        {
            return s / p;
        }

        public void Print()
        {
            Console.WriteLine("Фигура {0}, площадь {1}, периметр {2}, соотношение {3}, color {4}", Name, getSqare(), getPerimetr(), Otnoshenie(getSqare(), getPerimetr()), ColorFigure);
        }
    }
}
