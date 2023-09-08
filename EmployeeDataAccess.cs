namespace SingleResponsibilityPrinciple
{
    // Improved design following SRP: Separate classes for different responsibilities
    class EmployeeDataAccess
    {
        public void SaveEmployee(Employee employee)
        {
            // Code to save employee's data to a database
            Console.WriteLine("Employee data saved to the database.");
        }
    }
}
