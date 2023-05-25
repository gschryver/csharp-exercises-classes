using System;

namespace Classes
{
    public class Employee
    {
        // to avoid the weird non-nullable property thing, we can add a ? after the type to make it nullable
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}