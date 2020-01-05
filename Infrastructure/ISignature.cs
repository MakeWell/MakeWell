using System.ComponentModel.DataAnnotations;

namespace MakeWell.Infrastructure
{
    public interface ISignature 
        : IDbKey
        , IDbStamp
        , IDbFilter
    {
    }
}
