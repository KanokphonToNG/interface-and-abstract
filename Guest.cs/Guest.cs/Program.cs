using System;
using System.Xml.Linq;

public class Guest : User, Member
{
    public Guest(string name, string email)
        : base(name, email)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Guest: {Name}, Email: {Email}");
    }

    public void Register()
    {
        Console.WriteLine($"{Name} (Guest) registered successfully.");
    }

    public void ShowRole()
    {
        Console.WriteLine("Role: Guest");
    }
}