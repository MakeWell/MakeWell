using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;

namespace MakeWell.Data.Google.Sheets
{
    public static class GoogleSheetsResult
    {
        public static string[][] GetStrings(SheetsService service, string spreadsheetId, string range)
        {
            var request = GetRequest(service, spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            var result = StringifyValues(values);
            return result;
        }
        private static SpreadsheetsResource.ValuesResource.GetRequest GetRequest(SheetsService service, string spreadsheetId, string range)
        {
            return service
                    .Spreadsheets
                    .Values
                    .Get(spreadsheetId, range);
        }
        private static string[][] StringifyValues(IList<IList<Object>> values)
        {
            var result = new List<string[]>();

            foreach (var row in values)
            {
                result.Add(StringifyRow(row));
            }
            return result.ToArray();
        }
        private static string[] StringifyRow(IList<Object> row)
        {
            var result = new List<string>();

            foreach (var item in row)
            {
                result.Add(item.ToString());
            }
            return result.ToArray();
        }
    }
}
