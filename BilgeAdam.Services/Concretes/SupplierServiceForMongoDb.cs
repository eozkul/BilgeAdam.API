using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Services.Abstractions;

namespace BilgeAdam.Services.Concretes
{
    internal class SupplierServiceForMongoDb : ISupplierService
    {
        public List<SupplierListDto> GetAllSuppliers()
        {
            return new List<SupplierListDto>();
        }
    }
}