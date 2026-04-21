namespace GLMS_Part2.Services;
    using System.Text.Json;

    public class CurrencyService
    {
    private readonly HttpClient _http;

    public CurrencyService(HttpClient http)
    {
        _http = http;
    }

    //getting livw USD exhange from API
    public async Task<double> GetRate()
    {
        var response = await _http.GetStringAsync
            ("https://api.exchangerate-api.com/v4/latest/USD");

        using var doc = JsonDocument.Parse(response);

        return doc.RootElement
            .GetProperty("rates")
            .GetProperty("ZAR")
            .GetDouble();
    }
}

