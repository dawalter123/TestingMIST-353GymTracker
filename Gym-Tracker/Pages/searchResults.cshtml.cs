using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gym_Tracker.Pages
{
    public class searchResultsModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public string JsonData { get; set; }

        public searchResultsModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }


    }
}
