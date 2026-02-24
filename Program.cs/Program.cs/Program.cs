using System;

class Program
{
    static void Main(string[] args)
    {
        StarterMember system = new StarterMember();

        Student s1 = new Student("Anan", "anan@email.com", "S001");
        Teacher t1 = new Teacher("Suda", "suda@email.com", "Professor");
        Guest g1 = new Guest("John", "john@email.com");

        s1.Register();
        t1.Register();
        g1.Register();

        system.AddMember(s1);
        system.AddMember(t1);
        system.AddMember(g1);

        system.ShowAllMembers();

        Console.ReadLine();
    }
}