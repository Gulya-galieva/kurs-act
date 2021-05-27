using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbManager;
using KursActWeb.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KursActWeb.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly StoreContext db; 
        public IndexModel(StoreContext context)
        {
            db = context;
        }

        public List<ContractCardViewModel> ContractsList { get; set; }
        
        public IActionResult OnGet()
        {
            ContractsList = new List<ContractCardViewModel>();
            foreach (var item in db.Contracts)
                ContractsList.Add(new ContractCardViewModel(item.Id));

            return Page();
        }
    }
}