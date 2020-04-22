namespace OneFoodBowl.web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OneFoodBowl.web.Data;
    using OneFoodBowl.web.Data.Entities;
    using OneFoodBowl.web.Helpers;
    using OneFoodBowl.web.Models;
    using System.Threading.Tasks;

    public class CustomersController : Controller
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;
        private readonly IImageHelper imageHelper;

        public CustomersController(DataContext dataContext,
           ICombosHelper combosHelper,
           IImageHelper imageHelper)
        {
            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
            this.imageHelper = imageHelper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Customers.ToListAsync()); ;
        }
        public IActionResult Create()
        {
            var model = new CustomerViewModel
            {
                Genders = combosHelper.GetComboGenders()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    BirthDate = model.BirthDate,
                    Height = model.Height,
                    Weight = model.Weight,
                    Gender = await dataContext.Genders.FirstOrDefaultAsync(m=>m.Id==model.GenderId),
                    ImageUrl = await imageHelper.UploadImageAsync(model.ImageFile,model.FirstName,"Customers") 
                };
                dataContext.Customers.Add(customer);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
