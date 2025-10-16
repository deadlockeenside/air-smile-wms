using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;

namespace AirSmileWMS.Infrastructure.Services;

internal static class GoogleSheetService
{
    private const string APIKey = "key.json";
    private const string SheetId = "1AJ_xdaZKKvCDi84XbvHf-juWThfGFuWdKm9QBl094MY";

    public static readonly SheetsService SheetsService = new SheetsService(new BaseClientService.Initializer
    {
        HttpClientInitializer = GoogleCredential.FromFile(APIKey).CreateScoped(SheetsService.Scope.Spreadsheets),
        ApplicationName = "Air-Smile WMS Admin"
    });
}
