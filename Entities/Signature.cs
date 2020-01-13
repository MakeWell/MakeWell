using MakeWell.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MakeWell.Entities
{
    public class Signature : ISignature
    {
        public Signature()
        {

        }
        
        private static Signature SignSignature (string stamp = "")
        {
            Signature signature = new Signature();

            var stampInfo = GetProperties(stamp);
            if (true)
            {
                signature.ActionStamp = stampInfo["Action"];
                signature.ContextStamp = stampInfo["Context"];
                signature.UserStamp = stampInfo["User"];
                signature.TimeStamp = DateTime.Now.ToString();
            }
            return signature;
        }

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

        public static Signature Sign(string stamp = "User:MakeWell;Action:AddEntity;Context:Neveram;")
        {
            return SignSignature(stamp);
        }

        private static IDictionary<string, string> GetProperties(string stamp)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (string item in stamp.Split(";", StringSplitOptions.RemoveEmptyEntries))
            {
                string[] splittedItem = item.Split(":", StringSplitOptions.RemoveEmptyEntries);
                result.Add(splittedItem[0], splittedItem[1]);
            }
            return result;
        }

        public override string ToString()
        {
            return "Look Inside";
        }
    }
}