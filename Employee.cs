using System;

namespace EmployeeComparisonApp
{
    // Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        // Property for employee's unique identifier
        public int Id { get; set; }
        
        // Property for employee's first name
        public string FirstName { get; set; }
        
        // Property for employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if either of the objects are null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return ReferenceEquals(emp1, emp2);

            // Compare Id properties to determine equality
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator as a counterpart to the == operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to ensure consistency with operator overloads
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
                return this == employee;
            return false;
        }

        // Override GetHashCode, as Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}