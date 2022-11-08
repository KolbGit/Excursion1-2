using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок1_31._10_
{
    internal class Student : Person
    {
        decimal scolarship;

        public decimal Scolarship { get { return scolarship; } set { scolarship = value; } }

        public Student(string name, DateTime dateBirthd, string sex, double weight, decimal scolarship)
            :base(name, dateBirthd, sex, weight)
        {
            this.scolarship = scolarship;
        }

        new public string InfoString()
        {
            string inf = $"\nStudent\nname: {Name}" +
                         $"\ndate birthd: {DateBirthd}" +
                         $"\nsex: {Sex}" +
                         $"\nweight: {Weight}";

            inf = inf + $"\nctipendia: {scolarship} pyb";
            return inf;
        }
    }
}
