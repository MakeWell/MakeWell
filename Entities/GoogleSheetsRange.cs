using MakeWell;
using MakeWell.Entities;
using MakeWell.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeWell.Entities
{
    public class GoogleSheetsRange
        : Entity
        , IGoogleSheetsRange
    {
        public GoogleSheetsRange(string range, string rangeSplitter = "!", string cellRangeSplitter = ":")
        {

            this.RangeSplitter = rangeSplitter;
            string[] rangeSplit = range.Split(rangeSplitter);
            this.SheetName = rangeSplit[0];
            this.CellRange = rangeSplit[1];

            this.CellRangeSplitter = cellRangeSplitter;
            string[] cellRangeSplit = CellRange.Split(cellRangeSplitter);
            this.FirstCell = cellRangeSplit[0];
            this.LastCell = cellRangeSplit[1];
        }

        public string RangeSplitter { get; private set; }
        public string SheetName { get; set; }
        public string CellRange { get; set; }
        public string CellRangeSplitter { get; private set; }
        public string FirstCell { get; set; }
        public string FirstColumn { get; set; }
        public string FirstRow { get; set; }
        public string LastCell { get; set; }
        public string LastColumn { get; set; }
        public string LastRow { get; set; }
    }
}
