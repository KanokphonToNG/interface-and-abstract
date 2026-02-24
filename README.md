# Member Management System - Class Diagram

## UML Class Diagram

```mermaid
classDiagram

%% ======================
%% Interface
%% ======================
class Member {
    <<interface>>
    +Register() void
    +ShowRole() void
}

%% ======================
%% Abstract Class
%% ======================
class User {
    <<abstract>>
    -Name : string
    -Email : string
    +User(name : string, email : string)
    +ShowInfo() void*
}

%% ======================
%% Concrete Classes
%% ======================
class Student {
    -StudentID : string
    +Student(name : string, email : string, studentID : string)
    +ShowInfo() void
    +Register() void
    +ShowRole() void
}

class Teacher {
    -Position : string
    +Teacher(name : string, email : string, position : string)
    +ShowInfo() void
    +Register() void
    +ShowRole() void
}

class Guest {
    +Guest(name : string, email : string)
    +ShowInfo() void
    +Register() void
    +ShowRole() void
}

class StarterMember {
    -members : List~User~
    +AddMember(user : User) void
    +ShowAllMembers() void
}

%% ======================
%% Relationships
%% ======================

User <|-- Student
User <|-- Teacher
User <|-- Guest

Member <|.. Student
Member <|.. Teacher
Member <|.. Guest

StarterMember --> User
