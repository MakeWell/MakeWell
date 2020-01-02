using System.ComponentModel.DataAnnotations;

namespace MakeWell
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
        string Datastamp { get; set; }

        string Name { get; set; }

    }
}