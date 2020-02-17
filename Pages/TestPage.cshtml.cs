
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspDotNetPrimer.Pages
{
    public class TestPageModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public TestPageModel( ILogger<PrivacyModel> logger )
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
