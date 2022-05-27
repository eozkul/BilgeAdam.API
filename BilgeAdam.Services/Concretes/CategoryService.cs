using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Concretes
{
    internal class CategoryService : ICategoryService
    {
        private readonly NorthwindDbContext dbContext;

        public CategoryService(NorthwindDbContext dbContext)
        {
            this.dbContext=dbContext;
        }

        public bool AddNewCategory(CategoryAddDto dto)
        {
            var @new = new Category
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description,
            };
            dbContext.Add(@new);
            return dbContext.SaveChanges()>0;
        }

        public CategoryDto GetCategoryById(int id)
        {
            return dbContext.Categories.Where(x=>x.CategoryID==id).Select(c => new CategoryDto
            {
                CategoryName = c.CategoryName,
                Description = c.Description,
            }).SingleOrDefault();
        }

        public PagedList<List<CategoryListDto>> GetPagedCategories(int count,int page)
        {
            var data= dbContext.Categories.Skip((page-1)*count).Take(count).Select(c => new CategoryListDto
            {
                CategoryId = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description,
            }).ToList();
            var totalCount = dbContext.Categories.Skip(page * count).Count();
            return new PagedList<List<CategoryListDto>>() { Data=data, TotalCount=totalCount};
        }

        public bool RemoveCategory(int id)
        {
           var entity=dbContext.Categories.SingleOrDefault(x => x.CategoryID == id);
            if (entity == null) { return false; }
            dbContext.Categories.Remove(entity);
            return dbContext.SaveChanges() > 0;

        }
    }
}
