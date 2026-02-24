using System;
using System.Xml.Linq;

public class Student : User, Member
{
    public string StudentID { get; set; }

    public Student(string name, string email, string studentID)
        : base(name, email)
    {
        StudentID = studentID;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Student: {Name}, ID: {StudentID}, Email: {Email}");
    }

    public void Register()
    {
        Console.WriteLine($"{Name} (Student) registered successfully.");
    }

    public void ShowRole()
    {
        Console.WriteLine("Role: Student");
    }
}