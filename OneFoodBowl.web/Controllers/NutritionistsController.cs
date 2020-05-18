using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneFoodBowl.web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OneFoodBowl.web.Data;
    using OneFoodBowl.web.Data.Entities;
    using OneFoodBowl.web.Helpers;
    using OneFoodBowl.web.Models;
    using System.Threading.Tasks;

    public class NutritionistsController : Controller
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;
        private readonly IImageHelper imageHelper;

        public NutritionistsController(DataContext dataContext,
           ICombosHelper combosHelper,
           IImageHelper imageHelper)
        {
            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
            this.imageHelper = imageHelper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.Nutritionists.ToListAsync());
        }
        public IActionResult Create()
        {
            var model = new NutritionistViewModel
            {
                Genders = combosHelper.GetComboGenders()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NutritionistViewModel model)
        {
            if (ModelState.IsValid)
            {
                var nutritionist = new Nutritionist
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    HireDate = model.HireDate,
                    Gender = await dataContext.Genders.FirstOrDefaultAsync(m => m.Id == model.GenderId),
                    ImageUrl = await imageHelper.UploadImageAsync(model.ImageFile, model.FirstName, "Nutritionists")
                };
                dataContext.Nutritionists.Add(nutritionist);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
