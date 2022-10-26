using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClientManagement.Controllers;
using ClientManagement.Data;


namespace ClientManagement.Pages
{
    public class IndexModel : PageModel
    {
        CustomersController _customersController;


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async void OnGet()
        {
           await _customersController.Index();
        }
    }
}