using System;
using System.Collections;

public class EmployeeDAL
{
    private ArrayList employees = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        if (e == null)
            return false;

        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                employees.Remove(emp);
                return true;
            }
        }
        return false;
    }

    public string? SearchEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                return emp.EmployeeName;
            }
        }
        return null;
    }

    public Employee[] GetAllEmployeesListAll()
    {
        Employee[] empArray = new Employee[employees.Count];
        employees.CopyTo(empArray);
        return empArray;
    }
}
