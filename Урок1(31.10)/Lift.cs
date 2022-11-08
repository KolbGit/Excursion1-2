using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок1_31._10_
{
    internal class Lift
    {
        string name;
        double maxGryz;
        List<Person> list;

        public string Nmae { get { return name; } }

        public double MaxGryz { get { return maxGryz; } }

        public List<Person>List { get { return list; } }

        public double CurrentWeight 
        {
            get
            {
                double ves = 0;
                foreach (Person person in list)
                {
                    ves += person.Weight;
                }
                return ves;
            }
        }

        public void AddPerson(Person person)
        {
            if(CurrentWeight+person.Weight <= MaxGryz) list.Add(person);
            else 
            { 
                Console.WriteLine($"\n===========================" +
                                  $"\n{person.Name} sorry, but lift has max people"); 
            }
        }

        public void RemovePerson(Person person)
        {
            list.Remove(person);
        }

        public void InfoPerson()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Student) Console.WriteLine(((Student)list[i]).InfoString());
                if (list[i] is Teacher) Console.WriteLine(((Teacher)list[i]).InfoString());
            }
        }

        public Lift(string name, double maxGryz, List<Person> list)
        {
            this.name = name;
            this.maxGryz = maxGryz;
            this.list = list;
        }
    }
}
