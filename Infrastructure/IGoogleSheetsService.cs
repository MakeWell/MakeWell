using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;

namespace MakeWell.Data.Google.Sheets
{
    public interface IGoogleSheetsService
    {
        string[] Scopes { get; }
        string ApplicationName { get; }
        SheetsService Service { get; }
        UserCredential Credential { get; }
    }
}
