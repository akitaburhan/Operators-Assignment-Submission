using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate first Employee object and set properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Instantiate second Employee object and set properties
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded == operator
            if (employee1 == employee2)
            {
                Console.WriteLine("The two employees are considered equal.");
            }
            else
            {
                Console.WriteLine("The two employees are not equal.");
            }

            // Wait for the user to press a key before closing the console
            Console.ReadKey();
        }
    }
}