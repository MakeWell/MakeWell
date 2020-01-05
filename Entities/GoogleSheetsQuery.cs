using MakeWell.Data.Google.Sheets;
using MakeWell.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MakeWell.Entities
{
    public class GoogleSheetsQuery 
        : Entity
        , IGoogleSheetsQuery
    {
        public string SpreadsheetId { get; set; }
        public string Range { get; set; }
        public bool IsValid { get; set; }

        public bool Validate()
        {
            return true;
        }

    }
}
