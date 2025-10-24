using System;
class Student
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}
class program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "dia";
        Console.WriteLine("student name is :"+s.Name);
    }

}