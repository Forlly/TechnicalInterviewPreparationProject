using System.Collections.Generic;


/// <summary>
/// Конкретная реализация строителя
/// </summary>
public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;
    private readonly List<Employee> _employees;

    public EmployeeReportBuilder(List<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }

    public IEmployeeReportBuilder BuildHeader()
    {
        _employeeReport.Header = "EMPLOYEES REPORT";
        _employeeReport.Header += "\n__________________________________________ ";
        
        return this;
    }

    public IEmployeeReportBuilder BuildBody()
    {
        foreach (Employee e in _employees)
        {
            _employeeReport.Body +=$"\n Employee: {e.Name}  Salary: {e.Salary}$";
        }
        
        return this;
    }

    public IEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = "\n__________________________________________ ";
        _employeeReport.Footer += $"\n Total employees: {_employees.Count}$";
        
        return this; 
    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;

        return employeeReport;
    }
}
