using Gym_TrackerAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;



public class MembershipModel : PageModel
{
    private readonly HttpClient _httpClient;

    public MembershipModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IList<Gym_TrackerAPI.Data.MembershipData> MembershipList { get; set; } = new List<MembershipData>();

    public async Task<IActionResult> OnGetAsync(int ID)
    {
        try
        {
            var response = await _httpClient.GetAsync($"https://localhost:7219/api/Memberships/1\r\n{ID}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                MembershipList = JsonSerializer.Deserialize<List<MembershipData>>(responseContent);

                return Page();
            }
            else
            {
                TempData["Did not load data"] = "Didnt load membership data.";

                return RedirectToPage("Error");
            }
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = $"Error: {ex.Message}";
            return RedirectToPage("Error");
        }
    }
}