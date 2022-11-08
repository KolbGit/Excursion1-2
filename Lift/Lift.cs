//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Урок1_31._10_;

//namespace Lift
//{
//    class Lift
//    {
//        string name;
//        int maxWeight;
//        List<Person> list;

//        // 3 свойства
//        public string Name
//        { get { return name; } }

//        public int MaxWeight
//        { get { return maxWeight; } }

//        public List<Person> List
//        { get { return list; } }

//        public int CurrentWeight
//        {
//            get
//            {
//                int ves = 0;
//                foreach (Person person in list)
//                {
//                    ves += person.Weight;
//                }
//                return ves;
//            }
//        }

//        public void AddPerson(Person person)
//        {
//            if (CurrentWeight + person.Weight <= MaxWeight)
//            {
//                list.Add(person);
//            }
//            else
//            {
//                Console.WriteLine($"{person.Name} извини, но лифт уже перегружжен");
//            }

//        }

//        public void RemovePerson(Person person)
//        {
//            list.Remove(person);
//        }

//        public void InfoPerson()
//        {
//            for (int i = 0; i < list.Count; i++)
//            {
//                if (list[i] is Student)
//                {
//                    Console.WriteLine(((Student)list[i]).InfoString());
//                }

//                if (list[i] is Teacher)
//                {
//                    Console.WriteLine(((Teacher)list[i]).InfoString());
//                }
//            }
//        }
//    }
