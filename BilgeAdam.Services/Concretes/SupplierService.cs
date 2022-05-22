using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;

namespace BilgeAdam.Services.Concretes
{
    internal class SupplierService : ISupplierService
    {
        private readonly NorthwindDbContext dbContext;

        public SupplierService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool AddNewSupplier(SupplierAddDto dto)
        {
            var @new = new Supplier
            {
                Address = dto.Address,
                City = dto.City,
                CompanyName = dto.CompanyName,
                ContactName = dto.ContactName,
                ContactTitle = dto.ContactTitle,
                Country = dto.Country,
                Fax = dto.Fax,
                Phone = dto.Phone,
                PostalCode = dto.PostalCode,
                Region = dto.Region,
            };
            dbContext.Add(@new);
            return dbContext.SaveChanges() > 0;
        }

        public PagedList<List<SupplierListDto>> GetPagedSuppliers(int count,int page)
        {
            var data = dbContext.Suppliers.Skip((page - 1) * count).Take(count).Select(x => new SupplierListDto
            {
                Id = x.SupplierID,
                Address = $"{x.Address}, {x.Region}, {x.City}/{x.Country.ToUpper()}",
                CompanyName = x.CompanyName,
                ContactName = x.ContactName,
                Title = x.ContactTitle,
                Fax = x.Fax,
                Phone = x.Phone,
            }).ToList();
            var totalCount = dbContext.Suppliers.Skip(page * count).Count();
            return new PagedList<List<SupplierListDto>>() { Data = data, TotalCount = totalCount };
        }

        public SupplierDto GetSupplierById(int id)
        {
            return dbContext.Suppliers.Where(x => x.SupplierID == id).Select(s => new SupplierDto
            {
                Address = s.Address,
                City = s.City,
                CompanyName = s.CompanyName,
                ContactName = s.ContactName,
                ContactTitle = s.ContactTitle,
                Country = s.Country,
                Fax = s.Fax,
                Phone = s.Phone,
                PostalCode = s.PostalCode,
                Region = s.Region,
            }).SingleOrDefault();
        }

        public bool RemoveSupplier(int id)
        {
            var entity = dbContext.Suppliers.SingleOrDefault(x => x.SupplierID == id);
            if (entity is null)
            {
                return false;
            }
            dbContext.Suppliers.Remove(entity);
            return dbContext.SaveChanges() > 0;
        }
    }
}