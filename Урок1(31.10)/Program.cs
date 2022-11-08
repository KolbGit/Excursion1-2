using Урок1_31._10_;

//Person per = new Person("Tom", new DateTime(1990, 4, 6), "men");
//Console.WriteLine(per.InfoString());

Teacher tec = new Teacher("Linda", new DateTime(1987, 9, 21), "woman", 13, 73);
Console.WriteLine(tec.InfoString());

Teacher tec2 = new Teacher("Pavel", new DateTime(1982, 3, 26), "man", 17, 78);
Console.WriteLine(tec2.InfoString());

Student st = new Student("Vlad", new DateTime(2003, 12, 30), "man", 125, 72);
Console.WriteLine(st.InfoString());

Student st2 = new Student("Stas", new DateTime(2003, 11, 20), "man", 112, 85);
Console.WriteLine(st2.InfoString());

Student st3 = new Student("Lesha", new DateTime(2003, 2, 15), "man", 132, 69);
Console.WriteLine(st3.InfoString());

List<Person> list = new List<Person>()
{
    tec,
    tec2,
    st,
    st2,
    st3,
};

Console.WriteLine("\n=================================");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].Name);
}

Console.WriteLine("\n=================================");
for (int i = 0; i < list.Count; i++)
{
    if (list[i] is Student) Console.WriteLine(list[i].Name);
}

Lift lf = new Lift("lift", 100, new List<Person>());
Lift lf2 = new Lift("lift2", 150, new List<Person>());

//lf.AddPerson(tec);
//lf.AddPerson(tec2);
////lf.InfoPerson();
//lf.RemovePerson(tec);
//lf.InfoPerson();

lf2.AddPerson(st);
lf2.InfoPerson();
lf.AddPerson(st2);
lf.InfoPerson();
//lf.AddPerson(st3);
//lf.InfoPerson();