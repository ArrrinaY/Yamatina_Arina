using System;
using System.Reflection;

public class Student
{
    private string name = "Арина";
    private int age = 20;
}

class Task1
{
    static void Main()
    {
        Student student = new Student();

        Type type = typeof(Student);

        FieldInfo nameField = type.GetField("name", 
            BindingFlags.NonPublic | BindingFlags.Instance);

        string oldName = (string)nameField.GetValue(student);
        Console.WriteLine($"Старое имя: {oldName}");

        nameField.SetValue(student, "Мария");

        string newName = (string)nameField.GetValue(student);
        Console.WriteLine($"Новое имя: {newName}");
    }
}