using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProgramBuilder : MonoBehaviour
{
    static List<Employee> employees = new()
    {
        new Employee { Name = "Vitalii", Salary = 300 },
        new Employee { Name = "Ivan", Salary = 100 },
        new Employee { Name = "Fedor", Salary = 200 }
    };

    private static EmployeeReportBuilder _builder = new EmployeeReportBuilder(employees);
    private EmployeeReportDirector _director = new EmployeeReportDirector(_builder);

    private void Start()
    {
        _director.Build();
        EmployeeReport report = _builder.GetReport();
        Debug.Log(report);
    }
}
