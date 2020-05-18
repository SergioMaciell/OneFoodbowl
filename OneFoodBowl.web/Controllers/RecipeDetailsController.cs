using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneFoodBowl.web.Data;
using OneFoodBowl.web.Data.Entities;
using OneFoodBowl.web.Helpers;
using OneFoodBowl.web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OneFoodBowl.web.Controllers
{
    public class RecipeDetailsController : Controller
    {
        private readonly DataContext dataContext;
        private readonly ICombosHelper combosHelper;
        private readonly IImageHelper imageHelper;

        public RecipeDetailsController(DataContext dataContext, ICombosHelper combosHelper,
           IImageHelper imageHelper)
        {

            this.dataContext = dataContext;
            this.combosHelper = combosHelper;
            this.imageHelper = imageHelper;
        }

        // GET: RecipeDetails
        public async Task<IActionResult> Index()
        {
            return View(await dataContext.RecipeDetails.ToListAsync());
        }
        public IActionResult Create()
        {
            var model = new RecipeDetailViewModel
            {
                RecipeTypes = combosHelper.GetComboRecipeTypes()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecipeDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var recipeDetail = new RecipeDetail
                {
                    Name = model.Name,
                    Instruction = model.Instruction,
                    Ingredients = model.Ingredients,
                    RecipeType = await dataContext.RecipeTypes.FirstOrDefaultAsync(m => m.Id == model.RecipeTypeId),
                    ImageUrl = await imageHelper.UploadImageAsync(model.ImageFile, model.Name, "RecipeDetail")
                };
                dataContext.RecipeDetails.Add(recipeDetail);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}