using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneFoodBowl.web.Data;
using OneFoodBowl.web.Data.Entities;
using OneFoodBowl.web.Helpers;
using OneFoodBowl.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneFoodBowl.web.Controllers
{
    public class CreatePlanController : Controller 
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;
        private readonly IImageHelper imageHelper;

        public CreatePlanController(DataContext dataContext,
           ICombosHelper combosHelper,
           IImageHelper imageHelper)
        {
            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
            this.imageHelper = imageHelper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.CreatePlans.ToListAsync());
        }
        public IActionResult Create()
        {
            var model = new CreatePlanViewModel
            {
                RecipeDetails = combosHelper.GetComboRecipes()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePlanViewModel model)
        {
            if (ModelState.IsValid)
            {
                var createPlan = new CreatePlan
                {
                   Name = model.Name,
                   RecipeDetail = await dataContext.RecipeDetails.FirstOrDefaultAsync(m => m.Id == model.RecipeDetailId),
                };
                dataContext.CreatePlans.Add(createPlan);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}