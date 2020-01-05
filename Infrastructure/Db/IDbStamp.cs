namespace MakeWell.Infrastructure
{
    public interface IDbStamp
    {
        string TimeStamp { get; set; }
        string DataStamp { get; set; }
        string UserStamp { get; set; }
        string ContextStamp { get; set; }
        string ActionStamp { get; set; }
    }
}