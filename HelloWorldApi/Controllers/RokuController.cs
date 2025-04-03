using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("/roku")]
public class RokuController : ControllerBase
{
    [HttpGet("{key}")]
    public async Task<IActionResult> KeyPress(string key)
    {
        // Log the key press
        Console.WriteLine($"Someone hit the key {key}");

        // Send the key press to the Roku
        var client = new RokuClient("192.168.0.207");
        await client.SendKeyPressAsync(key);

        // Return a success response
        return Ok($"Key pressed: {key}");
    }
}