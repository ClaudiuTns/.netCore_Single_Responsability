using System;

namespace SingleResponsibilityPrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                Name = "John Doe",
                Id = 123
            };
            
            EmployeeDataAccess dataAccess = new EmployeeDataAccess();
            dataAccess.SaveEmployee(employee);
            
            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport(employee);
        }
    }
}
