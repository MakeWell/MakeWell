using MakeWell.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace MakeWell.Entities
{
    public class Signature : ISignature
    {
        #region Key
        [Key]
        public int Id { get; set; }
        #endregion
        #region Stamps
        [Timestamp]
        public string TimeStamp { get; set; }
        public string DataStamp { get; set; }
        public string UserStamp { get; set; }
        public string ContextStamp { get; set; }
        public string ActionStamp { get; set; }
        #endregion
        #region Filters
        public bool IsDeleted { get; set; }
        public string GlobalContext { get; set; }
        public string Tags { get; set; }

        #endregion
        
        public byte[] Timestamp { get; set; }

        public override string ToString()
        {
            return "Look Inside";
        }
    }
}