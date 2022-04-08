// See https://aka.ms/new-console-template for more information
using SEDC.Advance.Class01.L1.Abstract_class;
using SEDC.Advance.Class01.L1.Classes;
using SEDC.Advance.Class01.L1.Interfaces;

IUser teacher1 = new Teacher
{
    Id = 1,
    Name = "Aleksandar",
    Username = "aleksandar",
    Password = "aleks123",
    Subject = "C# Advance"
};

IUser teacher2 = new Teacher
{
    Id = 2,
    Name = "Stefan",
    Username = "stefan",
    Password = "stefan123",
    Subject = "Java Script"
};

IUser student1 = new Student
{
    Id = 3,
    Name = "Aneta",
    Username = "aneta",
    Password = "aneta123",
    Grades = new List<int> { 1, 2, 3 }
};

IUser student2 = new Student
{
    Id = 4,
    Name = "Igor",
    Username = "igor",
    Password = "igor123",
    Grades = new List<int> { 4, 5, 6}
};

teacher1.PrintUser();
teacher2.PrintUser();
student1.PrintUser();
student2.PrintUser();


