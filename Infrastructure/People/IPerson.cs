using MakeWell.Entities;
using MakeWell.Infrastructure;
using MakeWell.People;

namespace MakeWell.Infrastructure
{
    public interface IPerson : IEntity
    {
        PrivateDetail[] PrivateDetails { get; set; }
        string Gender { get; set; }
    }
}
