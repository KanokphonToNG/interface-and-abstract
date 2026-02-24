using System;
using System.Xml.Linq;

public class Teacher : User, Member
{
    public string Position { get; set; }

    public Teacher(string name, string email, string position)
        : base(name, email)
    {
        Position = position;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Position: {Position}, Email: {Email}");
    }

    public void Register()
    {
        Console.WriteLine($"{Name} (Teacher) registered successfully.");
    }

    public void ShowRole()
    {
        Console.WriteLine("Role: Teacher");
    }
}