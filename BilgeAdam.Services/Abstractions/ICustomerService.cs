using BilgeAdam.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICustomerService
    {
        PagedList<List<CustomerListDto>> GetPagedCustomer(int count, int page);
        CustomerDto GetById(string id);
        bool CustomerAddNew(CustomerAddDto dto);
        bool DeleteCustomer(string id);
    }
}
