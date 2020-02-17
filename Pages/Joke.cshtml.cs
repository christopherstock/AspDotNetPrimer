
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspDotNetPrimer.Pages
{
    public class JokeModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public JokeModel( ILogger<PrivacyModel> logger )
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
