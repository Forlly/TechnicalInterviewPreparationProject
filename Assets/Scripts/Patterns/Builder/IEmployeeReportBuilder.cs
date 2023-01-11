

/// <summary>
/// определяет интерфейс для создания различных частей объекта Product
/// </summary>
public interface IEmployeeReportBuilder 
{
    IEmployeeReportBuilder BuildHeader();

    IEmployeeReportBuilder BuildBody();

    IEmployeeReportBuilder BuildFooter();

    EmployeeReport GetReport();
}
