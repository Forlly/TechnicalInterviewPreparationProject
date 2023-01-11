

/// <summary>
/// Класс директора, создает объект, используя объекты Builder
/// </summary>
public class EmployeeReportDirector 
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder
            .BuildHeader()
            .BuildBody()
            .BuildFooter();
    }
}
