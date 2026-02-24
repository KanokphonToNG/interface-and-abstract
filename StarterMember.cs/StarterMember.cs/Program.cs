using System;
using System.Collections.Generic;

public class StarterMember
{
    private List<User> members = new List<User>();

    public void AddMember(User user)
    {
        members.Add(user);
        Console.WriteLine("Member added successfully.\n");
    }

    public void ShowAllMembers()
    {
        Console.WriteLine("=== Member List ===");
        foreach (var m in members)
        {
            m.ShowInfo();
        }
    }
}