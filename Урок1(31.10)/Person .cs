using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок1_31._10_
{
    internal class Person
    {
        string name;
        DateTime dateBirthd;
        string sex;
        double weight;

        public string Name { get { return name; } }
        public DateTime DateBirthd { get { return dateBirthd; } }
        public string Sex { get { return sex; } }
        public double Weight { get { return weight; } }

        public Person(string name, DateTime dateBirthd, string sex, double weight)
        {
            this.name = name;
            this.dateBirthd = dateBirthd;
            this.sex = sex;
            this.weight = weight;
        }

        public string InfoString()
        {
            string inf = $"\nPerson\nname: {name}" +
                         $"\ndate birthd: {dateBirthd}" +
                         $"\nsex: {sex}" +
                         $"\nweight: {weight}";
            return inf;
        }
    }
}
