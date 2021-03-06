﻿using Microsoft.AspNetCore.Mvc.Rendering;
using OneFoodBowl.web.Data;
using System.Collections.Generic;
using System.Linq;

namespace OneFoodBowl.web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboGenders()
        {
            var list = dataContext.Genders.Select(
                c => new SelectListItem
                {
                    Text = c.Name,
                    Value = $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[debe seleccionar un género...]",
                Value = "0"
            });
            return list;
        }
        public IEnumerable<SelectListItem> GetComboRecipeTypes()
        {
            var list = dataContext.RecipeTypes.Select(
                c => new SelectListItem
                {
                    Text = c.Name,
                    Value = $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[debe seleccionar el tipo de receta...]",
                Value = "0"
            });
            return list;
        }
        public IEnumerable<SelectListItem> GetComboRecipes()
        {
            var list = dataContext.RecipeDetails.Select(
                c => new SelectListItem
                {
                    Text = c.Name,
                    Value = $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[debe seleccionar la receta...]",
                Value = "0"
            });
            return list;
        }
    }
}
