using System;
using RestSharp;
using Newtonsoft.Json.Linq;

public class AroFloService
{
    private readonly string _baseUrl = "https://api.aroflo.com";
    private readonly string _apiKey = "your_api_key_here"; // Add API key

    public JArray FetchData()
    {
        var client = new RestClient(_baseUrl);
        var request = new RestRequest("path/to/your/endpoint", Method.GET); // Add Endpointpath
        request.AddHeader("Authorization", $"Bearer {_apiKey}");

        var response = client.Execute(request);

        if (!response.IsSuccessful)
            throw new Exception("Failed to fetch data from AroFlo");

        return JArray.Parse(response.Content);
    }
}
