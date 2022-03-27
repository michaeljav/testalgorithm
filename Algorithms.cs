using System;
using System.Collections.Generic;
namespace testalgorithm
{


    class Algorithms
    {
        
       class Employee
        {
            //string name;
            public string name { get; set; }
            public int id { get; set; }
           // int id;
            //string department;
            public string department { get; set; }

            public Employee(string name, int id, string department)
            {
                this.name = name;
                this.id = id;
                this.department = department;
            }
        }

        static void Main(string[] args)
        {

            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();
            employeesById.Add(employee.id, employee);
            employeesById.Add(employee.id, employee2);
            employeesById.Add(employee.id, employee3);

            Employee e;
            if(employeesById.TryGetValue(9415, out e))
            {
                Console.WriteLine(e.name + " : " + e.department);
            }

            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("8F26B");
            productCodes.Add("0A43P");

            productCodes.Contains("0A43P");
        }
    }
}
