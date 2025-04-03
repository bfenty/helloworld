using System.Net.Http;
using System.Threading.Tasks;

public class RokuClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public RokuClient(string ipAddress)
    {
        _httpClient = new HttpClient();
        _baseUrl = $"http://{ipAddress}:8060/";
    }

    public async Task SendKeyPressAsync(string key)
    {
        // Log the key press
        Console.WriteLine($"Sending key press: {key}");

        // Send the key press to the Roku
        var url = $"{_baseUrl}keypress/{key}";
        try
        {
            var response = await _httpClient.PostAsync(url, null);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Key pressed successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to send key press. Status code: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending key press: {ex.Message}");
        }
    }
}