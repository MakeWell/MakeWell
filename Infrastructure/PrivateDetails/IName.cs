using MakeWell.Infrastructure;

namespace MakeWell.Naming
{
    public interface IName : IEntity
    {
        string Text { get; set; }
        string Kind { get; set; }
        string GetString();
    }
}
