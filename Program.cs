using System;
using System.Collections.Generic;
//Noa Denise Ishac NET23
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        // del 1
        Stack<Employee> employeeStack = new Stack<Employee>();

        // här skapar vi och lägger till fem objekt i stacken
        employeeStack.Push(new Employee { Id = 1, Name = "Lena", Gender = "Female", Salary = 50000 });
        employeeStack.Push(new Employee { Id = 2, Name = "Peter", Gender = "Male", Salary = 60000 });
        employeeStack.Push(new Employee { Id = 3, Name = "Alex", Gender = "Male", Salary = 55000 });
        employeeStack.Push(new Employee { Id = 4, Name = "Jessica", Gender = "Female", Salary = 70000 });
        employeeStack.Push(new Employee { Id = 5, Name = "Albin", Gender = "Male", Salary = 48000 });

        // skriver ut alla objekt i stacken
        Console.WriteLine("All items: ");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
        }
        Console.WriteLine($"Items in the stack: {employeeStack.Count}\n");

        // hämtar och skriver ut alla objekt med Pop-metoden
        Console.WriteLine("Retrive using Pop-method:");
        while (employeeStack.Count > 0)
        {
            Employee employee = employeeStack.Pop();
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
        }
        Console.WriteLine();

        // lägger till alla objekt igen
        employeeStack.Push(new Employee { Id = 1, Name = "Lena", Gender = "Female", Salary = 50000 });
        employeeStack.Push(new Employee { Id = 2, Name = "Peter", Gender = "Male", Salary = 60000 });
        employeeStack.Push(new Employee { Id = 3, Name = "Alex", Gender = "Male", Salary = 55000 });
        employeeStack.Push(new Employee { Id = 4, Name = "Jessica", Gender = "Female", Salary = 70000 });
        employeeStack.Push(new Employee { Id = 5, Name = "Albin", Gender = "Male", Salary = 48000 });

        // hämtar och skriver ut alla objekt med Peek-metoden
        Console.WriteLine("Retrive using Peek-method:");
        Console.WriteLine("Peek #1:");
        Employee peekedEmployee1 = employeeStack.Peek();
        Console.WriteLine($"Id: {peekedEmployee1.Id}, Name: {peekedEmployee1.Name}, Gender: {peekedEmployee1.Gender}, Salary: {peekedEmployee1.Salary}");
        Console.WriteLine($"Items left in the stack: {employeeStack.Count}");

        Console.WriteLine("Peek #2:");
        Employee peekedEmployee2 = employeeStack.Peek();
        Console.WriteLine($"Id: {peekedEmployee2.Id}, Name: {peekedEmployee2.Name}, Gender: {peekedEmployee2.Gender}, Salary: {peekedEmployee2.Salary}");
        Console.WriteLine($"Items left in the stack: {employeeStack.Count}\n");

        // kollar om objekt nr 3 finns i stacken
        Employee employee3 = new Employee { Id = 3, Name = "Alex", Gender = "Male", Salary = 55000 };
        bool containsEmployee3 = employeeStack.Contains(employee3);
        Console.WriteLine($"item 3 is in stack: {containsEmployee3}\n");

        // del 2 
        List<Employee> employeeList = new List<Employee>();

        // lägger till 5 objekt i listan
        employeeList.Add(new Employee { Id = 1, Name = "Lena", Gender = "Female", Salary = 50000 });
        employeeList.Add(new Employee { Id = 2, Name = "Peter", Gender = "Male", Salary = 60000 });
        employeeList.Add(new Employee { Id = 3, Name = "Alex", Gender = "Male", Salary = 55000 });
        employeeList.Add(new Employee { Id = 4, Name = "Jessica", Gender = "Female", Salary = 70000 });
        employeeList.Add(new Employee { Id = 5, Name = "Albin", Gender = "Male", Salary = 48000 });

        // kollar om ett visst objekt finns i listan
        Employee employee2 = new Employee { Id = 2, Name = "Peter", Gender = "Male", Salary = 60000 };
        bool containsEmployee2 = employeeList.Contains(employee2);
        Console.WriteLine(containsEmployee2
            ? "Employee 2 exists in the list."
            : "Employee 2 does not exist in the list."
        );

        // hittar och skriver första objektet i listan med gender : Male
        Console.WriteLine("\nFirst item in list with gender: \"Male\":");
        Employee firstMaleEmployee = employeeList.Find(employee => employee.Gender == "Male");
        Console.WriteLine($"Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");

        // hittar och skriver ut alla objekt i listan med gender : Male
        Console.WriteLine("\nAll items in list with gender: \"Male\":");
        List<Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");
        foreach (var maleEmployee in maleEmployees)
        {
            Console.WriteLine($"Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
        }
    }
}
