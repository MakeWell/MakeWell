using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeWell.Infrastructure
{
    public interface IVersion
    {
        [Key]
        int EntityId { get; set; }
        [Required]
        int VersionId { get; set; }
        
        [ForeignKey("SignatureID")]
        ISignature Signature { get; set; }

    }
}