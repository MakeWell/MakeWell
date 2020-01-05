namespace MakeWell.Infrastructure
{
    public interface IPrivateDetail: IEntity
    {
        string Value { get; set; }
        string Kind { get; set; }
    }
}
