using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }
    public double KPI { get; set; }
}

public class cau2bai25
{
    public static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter the number of people (2-10): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 10);

        Person[] people = new Person[n];
        GetPeopleInfo(people);
        DisplayPeopleInfo(people);
        DisplayProfessorCount(people);
    }

    public static void GetPeopleInfo(Person[] people)
    {
        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person();

            string roleInput;
            do
            {
                Console.Write($"Enter the role for person {i + 1} (ta, lec, gs): ");
                roleInput = Console.ReadLine().ToLower();
            } while (roleInput != "ta" && roleInput != "lec" && roleInput != "gs");

            switch (roleInput)
            {
                case "ta":
                    people[i].Role = "TeachingAssistant";
                    break;
                case "lec":
                    people[i].Role = "Lecturer";
                    break;
                case "gs":
                    people[i].Role = "Professor";
                    break;
            }

            Console.Write($"Enter the name for person {i + 1}: ");
            people[i].Name = Console.ReadLine();

            int age;
            do
            {
                Console.Write($"Enter the age for person {i + 1}: ");
            } while (!int.TryParse(Console.ReadLine(), out age) || age < 1);
            people[i].Age = age;

            double kpi;
            do
            {
                Console.Write($"Enter the KPI for person {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out kpi) || kpi < 0);
            people[i].KPI = kpi;
        }
    }

    public static void DisplayPeopleInfo(Person[] people)
    {
        Console.WriteLine("\nPeople Information:");
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Role: {person.Role}, Age: {person.Age}, KPI: {person.KPI}");
        }
    }

    public static void DisplayProfessorCount(Person[] people)
    {
        int professorCount = 0;
        foreach (var person in people)
        {
            if (person.Role == "Professor")
            {
                professorCount++;
            }
        }
        Console.WriteLine($"\nNumber of Professors: {professorCount}");
    }
}