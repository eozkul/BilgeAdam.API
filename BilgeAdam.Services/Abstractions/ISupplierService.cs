using BilgeAdam.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Abstractions
{
    public interface ISupplierService
    {
        PagedList<List<SupplierListDto>> GetPagedSuppliers(int count,int page);
        SupplierDto GetSupplierById(int id);
        bool AddNewSupplier(SupplierAddDto dto);
        bool RemoveSupplier(int id);
    }
}
