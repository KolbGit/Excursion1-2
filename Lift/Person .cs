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

        public string Name { get { return name; } }
        public DateTime DateBirthd { get { return dateBirthd; } }
        public string Sex { get { return sex; } }

        public Person(string name, DateTime dateBirthd, string sex)
        {
            this.name = name;
            this.dateBirthd = dateBirthd;
            this.sex = sex;
        }

        public string InfoString()
        {
            string inf = $"\nPerson\nname: {name}" +
                         $"\ndate birthd: {dateBirthd}" +
                         $"\nsex: {sex}";
            return inf;
        }
    }
}
