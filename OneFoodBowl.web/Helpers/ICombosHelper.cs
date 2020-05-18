

namespace OneFoodBowl.web.Helpers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    public interface ICombosHelper 
    {
        IEnumerable<SelectListItem> GetComboGenders();
        IEnumerable<SelectListItem> GetComboRecipeTypes();
        IEnumerable<SelectListItem> GetComboRecipes();
    }
}
