using System.ComponentModel.DataAnnotations;

namespace MakeWell.Infrastructure
{
    public interface IDbKey 
    {
        int Id { get; set; }
    }
}