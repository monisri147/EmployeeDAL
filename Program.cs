class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee(1, "Moni", 45000));
        dal.AddEmployee(new Employee(2, "Pranav", 55000));
        dal.AddEmployee(new Employee(3, "Nathiya", 35000));
        dal.AddEmployee(new Employee(4, "Mahesan", 25000));

        Console.WriteLine(dal.SearchEmployee(1)); 

        Employee[] list = dal.GetAllEmployeesListAll();
        foreach (Employee e in list)
        {
            Console.WriteLine($"{e.EmployeeID} {e.EmployeeName} {e.Salary}");
        }

        dal.DeleteEmployee(2);
    }
}