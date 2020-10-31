using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assetRegister.Models;
using assetRegister.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace assetRegister.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService jsonFileProductService;
        public IEnumerable<Product> products
        {
            get;private set;
        }
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService jsonFileProductService)
        {
            this.jsonFileProductService = jsonFileProductService;
            _logger = logger;
        }

        public void OnGet()
        {
            products =  jsonFileProductService.GetProducts();
        }
    }
}
