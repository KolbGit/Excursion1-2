using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Урок1_31._10_
{
    internal class Teacher : Person
    {
        int workExperiens;

        public int WorkExperiens { get { return workExperiens; } set { workExperiens = value; } }

        public Teacher(string name, DateTime dateBirthd, string sex, double weight, int workExperiens) 
            : base(name, dateBirthd, sex, weight)
        {
            this.workExperiens = workExperiens;
        }

        new public string InfoString()
        {
            string inf = $"\nTeacher\nname: {Name}" +
                         $"\ndate birthd: {DateBirthd}" +
                         $"\nsex: {Sex}" +
                         $"\nweight: {Weight}";

            inf = inf + $"\nstag: {workExperiens} let";
            return inf;
        }
    }
}
