using MakeWell.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace MakeWell.Entities
{
    public class Entity 
        : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DisplayText { get; set; }
        public Signature Signature { get; set; }
    }
}