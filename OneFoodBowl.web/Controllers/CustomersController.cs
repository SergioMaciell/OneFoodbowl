namespace OneFoodBowl.web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OneFoodBowl.web.Data;
    using System.Threading.Tasks;

    public class CustomersController : Controller
    {
        private readonly DataContext dataContext;

        public CustomersController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<IActionResult> Index()
        {
            return  View(await dataContext.Customers.ToListAsync()); ;
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}
