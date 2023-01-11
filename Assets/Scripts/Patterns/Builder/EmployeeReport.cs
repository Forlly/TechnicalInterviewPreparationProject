using System.Text;

/// <summary>
/// Класс отчета о сотрудниках (объект, который должен быть создан/Product)
/// </summary>
public class EmployeeReport 
{
    public string Header { get; set; }

    public string Body { get; set; }

    public string Footer { get; set; }

    public override string ToString() =>
        new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
}
