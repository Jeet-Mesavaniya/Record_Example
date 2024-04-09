public record Person(string FirstName, string LastName, int Age);

class Program
{
    static void Main(string[] args)
    {
        // Creating a new Person record
        Person person1 = new Person("John", "Doe", 30);

        // Accessing properties of the record
        Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}, Age: {person1.Age}");

        // Creating a new Person record using with-expression to modify properties
        Person person2 = person1 with { Age = 35 };

        // Accessing properties of the updated record
        Console.WriteLine($"Name: {person2.FirstName} {person2.LastName}, Age: {person2.Age}");

        // Value-based equality comparison between records
        Console.WriteLine($"Are person1 and person2 equal? {person1.Equals(person2)}");
    }
}
