using BilgeAdam.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICategoryService
    {
        PagedList<List<CategoryListDto>> GetPagedCategories(int count,int page);
        CategoryDto GetCategoryById(int id);
        bool AddNewCategory(CategoryAddDto dto);
        bool RemoveCategory(int id);
    }
}
