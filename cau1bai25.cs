using System;

// Lớp Person trừu tượng
public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    protected string BankAccount { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public abstract string GetRole();
}

// Interface KPIEvaluator
public interface KPIEvaluator
{
    double CalculateKPI();
}

// Lớp TeachingAssistant kế thừa từ Person và implements KPIEvaluator
public class TeachingAssistant : Person, KPIEvaluator
{
    public string EmployeeID { get; set; }
    private int numberOfCourses;

    public TeachingAssistant(string name, int age, string gender, string employeeID, int numberOfCourses)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        this.numberOfCourses = numberOfCourses;
    }

    public override string GetRole()
    {
        return "Teaching Assistant";
    }

    public double CalculateKPI()
    {
        return numberOfCourses * 5;
    }
}

// Lớp Lecturer kế thừa từ Person và implements KPIEvaluator
public class Lecturer : Person, KPIEvaluator
{
    public string EmployeeID { get; set; }
    private int numberOfPublications;

    public Lecturer(string name, int age, string gender, string employeeID, int numberOfPublications)
        : base(name, age, gender)
    {
        EmployeeID = employeeID;
        this.numberOfPublications = numberOfPublications;
    }

    public override string GetRole()
    {
        return "Lecturer";
    }

    public double CalculateKPI()
    {
        return numberOfPublications * 7;
    }
}

// Lớp Professor kế thừa từ Lecturer và implements KPIEvaluator
public sealed class Professor : Lecturer, KPIEvaluator
{
    private static int countProfessors = 0;
    private int numberOfProjects;

    public Professor(string name, int age, string gender, string employeeID, int numberOfPublications, int numberOfProjects)
        : base(name, age, gender, employeeID, numberOfPublications)
    {
        this.numberOfProjects = numberOfProjects;
        countProfessors++;
    }

    public override string GetRole()
    {
        return "Professor";
    }

    public double CalculateKPI()
    {
        return (base.CalculateKPI()) + (numberOfProjects * 10);
    }
}

// Lớp chứa main()
class cau1bai25
{
    static void Main(string[] args)
    {
        // Tạo đối tượng TeachingAssistant
        TeachingAssistant ta = new TeachingAssistant("John Doe", 30, "Male", "TA001", 4);
        Console.WriteLine($"Role: {ta.GetRole()}, KPI: {ta.CalculateKPI()}");

        // Tạo đối tượng Lecturer
        Lecturer lec = new Lecturer("Jane Smith", 40, "Female", "LEC001", 12);
        Console.WriteLine($"Role: {lec.GetRole()}, KPI: {lec.CalculateKPI()}");

        // Tạo đối tượng Professor
        Professor prof = new Professor("Dr. Alice Johnson", 50, "Female", "PROF001", 20, 3);
        Console.WriteLine($"Role: {prof.GetRole()}, KPI: {prof.CalculateKPI()}");
        Console.WriteLine($"Number of Professors: {Professor.countProfessors}");
    }
}