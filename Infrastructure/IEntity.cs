using MakeWell.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeWell.Infrastructure
{
    public interface IEntity 
        : IDbKey
    {
        string EntityId { get; set; }
        string Name { get; set; }
        string Title { get; set; }
        string DisplayText { get; set; }
        Signature Signature { get; set; }
    }
}