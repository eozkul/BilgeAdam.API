using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
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
        public List<SupplierListDto> GetAllSuppliers()
        {
            return dbContext.Suppliers.Select(x => new SupplierListDto
            {
                Address = $"{x.Address}, {x.Region}, {x.City}/{x.Country.ToUpper()}",
                CompanyName = x.CompanyName,
                ContactName = x.ContactName,
                Title = x.ContactTitle,
                Fax = x.Fax,
                Phone = x.Phone,
            }).ToList();
        }
    }
}