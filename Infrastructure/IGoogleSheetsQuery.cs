using System;
using System.Collections.Generic;
using System.Text;

namespace MakeWell.Infrastructure
{
    public interface IGoogleSheetsQuery
    {
        string SpreadsheetId { get; set; }
        string Range { get; set; }
    }
}
