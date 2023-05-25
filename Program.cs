using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Acme, Inc.", new DateTime(2000, 1, 1));

            // Create three employees
            Employee employee1 = new Employee { FirstName = "Sylvia", LastName = "Plath", Title = "Creative Director", StartDate = new DateTime(2023, 1, 1) };
            Employee employee2 = new Employee { FirstName = "Carl", LastName = "Sagan", Title = "Astrophysicist", StartDate = new DateTime(2019, 1, 1) };
            Employee employee3 = new Employee { FirstName = "Jon", LastName = "Krakauer", Title = "Creative Specialist", StartDate = new DateTime(2018, 1, 1) };

            // Assign the employees to the company
            myCompany.Employees.Add(employee1);
            myCompany.Employees.Add(employee2);
            myCompany.Employees.Add(employee3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in myCompany.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {myCompany.Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}.");
            }
        }
    }
}