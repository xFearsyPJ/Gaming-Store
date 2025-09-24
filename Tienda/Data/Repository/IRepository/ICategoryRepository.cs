using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Tienda.Models;

namespace Tienda.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);
    }
}
