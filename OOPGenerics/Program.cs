using System.Diagnostics.Metrics;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace OOPGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employee = new Stack<Employee>();

            // Pushing employees to the stack
            employee.Push(new Employee(1, "Alex", "Male", 20000));
            employee.Push(new Employee(2, "Ambessa", "Female", 18000));
            employee.Push(new Employee(3, "Ana", "Female", 25000));
            employee.Push(new Employee(4, "Zian", "Male", 25000));
            employee.Push(new Employee(5, "Max", "Male", 22500));

            int Count = employee.Count;

            // Iterating over the stack to display employees and remaining count
            foreach (var people in employee)
            {
                Console.WriteLine($"Objects remaining in stack: {Count}");
                Console.WriteLine($"ID: {people.Id}, Name: {people.Name}, Gender: {people.Gender}, Salary: {people.Salary}");
                Count--;
            }

            Console.WriteLine("-----------------------------------------------------");

            List<Employee> tempList = new List<Employee>();

            // Pop all elements from the stack and store in a temporary list
            while (employee.Count > 0)
            {
                Console.WriteLine($"Objects remaining in stack: {employee.Count}");
                Employee emp = employee.Pop(); // Pops the top item from the stack
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Gender: {emp.Gender}, Salary: {emp.Salary}");

                tempList.Add(emp); // Add to temporary list for later restoration
            }

            // Push back the items to the stack from the temporary list
            foreach (var people in tempList)
            {
                employee.Push(people);
            }

            Console.WriteLine("-----------------------------------------------------");

            if (employee.Count > 0)
            {
                // Peek at the top element of the stack
                Console.WriteLine("Peeking at the top of the stack");
                Employee topEmployee = employee.Peek(); // Peek method to check the top element without removing it
                Console.WriteLine($"Top Employee - ID: {topEmployee.Id}, Name: {topEmployee.Name}, Gender: {topEmployee.Gender}, Salary: {topEmployee.Salary}");
                Console.WriteLine($"Objects left in stack: {employee.Count}");

                Employee stilltopEmployee = employee.Peek(); // Peek again to show that the stack hasn't been changed
                Console.WriteLine($"Top Employee (again) - ID: {stilltopEmployee.Id}, Name: {stilltopEmployee.Name}, Gender: {stilltopEmployee.Gender}, Salary: {stilltopEmployee.Salary}");
                Console.WriteLine($"Objects left in stack: {employee.Count}");
            }

            else
            {
                Console.WriteLine("There is nothing in the stack");
            }

            Console.WriteLine("-----------------------------------------------------");

            // Checking if employee number 3 exists in the main stack
            foreach (var people in employee)
            {
                Count++;
                if (Count == 3)
                {
                    Console.WriteLine("Employee number 3 exists in the main stack");
                }
            }

            Console.WriteLine("-----------------------------------------------------");

            List<Employee> employeeList = employee.ToList(); // Convert stack to list for easier indexing and searching
            var EmployeeTwo = employeeList[1];

            // Check if EmployeeTwo exists in the list
            if (employeeList.Contains(EmployeeTwo))
            {
                Console.WriteLine("Employee object 2 exists in the list");
            }

            else
            {
                Console.WriteLine("Employee object 2 does not exist in the list");
            }

            Console.WriteLine("-----------------------------------------------------");

            // Find first male employee in the list
            Employee? MaleEmployee = employeeList.Find(x => x.Gender == "Male");

            if (MaleEmployee != null)
            {
                Console.WriteLine("First Male Employee Found: ");
                Console.WriteLine(MaleEmployee);
            }
            else
            {
                Console.WriteLine("No male employee found in the list.");
            }

            Console.WriteLine("-----------------------------------------------------");
            // Find all male employees in the list
            List<Employee> AllMaleEmployee = employeeList.FindAll(x => x.Gender == "Male");

            if (AllMaleEmployee.Count > 0)
            {
                Console.WriteLine("Male Employees Found: ");
                foreach (var people in AllMaleEmployee)
                {
                    Console.WriteLine(people);
                }
            }
            else
            {
                Console.WriteLine("No male employees found in the list.");
            }
        }
    }
}
