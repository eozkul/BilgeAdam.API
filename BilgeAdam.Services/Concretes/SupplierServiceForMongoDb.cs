using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Services.Abstractions;

namespace BilgeAdam.Services.Concretes
{
    internal class SupplierServiceForMongoDb : ISupplierService
    {
        public bool AddNewSupplier(SupplierAddDto dto)
        {
            throw new NotImplementedException();
        }

        public PagedList<List<SupplierListDto>> GetPagedSuppliers(int count, int page)
        {
            throw new NotImplementedException();
        }

        public SupplierDto GetSupplierById(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSupplier(int id)
        {
            throw new NotImplementedException();
        }
    }
}