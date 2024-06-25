using System;
using System.Xml.Linq;

public interface KPI
{
    double CalculateKPI();
}
public class Student : Person, KPI
{
    public float gpa { get; set; }

    public double CalculateKPI()
    {
        return this.gpa;
    }
}
public Student(string name, int age, string major, float gpa) : base(name, age, major)
{
    this.gpa = gpa;
}
public class Teacher : Person, KPI
{
    public string Major { get; set; }
    public int Publications { get; set; }

    public Teacher(string name, int age, string major, int publications)
        : base(name, age, major)
    {
        this.Major = major;
        this.Publications = publications;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Major: {Major}, Publications: {Publications}";
    }

    public double CalculateKPI()
    {
        return 1.5 * this.Publications;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Nguyễn Tiến Dũng", 20, "CNTT&TT", 3.8f);
        Teacher teacher = new Teacher("Vũ Đức Việt", 38, "CNTT&TT", 5);

        Console.WriteLine(student.ToString());
        Console.WriteLine($"Student's KPI: {student.CalculateKPI()}");

        Console.WriteLine(teacher.ToString());
        Console.WriteLine($"Teacher's KPI: {teacher.CalculateKPI()}");
    }
}