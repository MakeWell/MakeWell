namespace MakeWell.Infrastructure
{
    public interface IGoogleSheetsRange
    {
        string FirstColumn { get; set; }
        string FirstRow { get; set; }
        int Id { get; set; }
        string LastColumn { get; set; }
        string LastRow { get; set; }
        string Name { get; set; }
        string SheetName { get; set; }
    }
}
