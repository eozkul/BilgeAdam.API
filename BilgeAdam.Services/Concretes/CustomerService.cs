using BilgeAdam.Common.Dtos;
using BilgeAdam.Data.Context;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;
namespace BilgeAdam.Services.Concretes
{
    public class CustomerService : ICustomerService
    {
        private readonly NorthwindDbContext dbContext;

        public CustomerService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool CustomerAddNew(CustomerAddDto dto)
        {
          var @new=new Customer
          { 
              CustomerID=dto.CustomerId,
               CompanyName=dto.CustomerName,
                ContactName=dto.ContactName,
                 Phone=dto.Phone,
                Address=dto.Address
          };
            dbContext.Add(@new);
            return dbContext.SaveChanges() > 0;     
        }

        public bool DeleteCustomer(string id)
        {
          var result=dbContext.Customers.SingleOrDefault(x => x.CustomerID == id);
          if (result == null) { return false; }
          dbContext.Customers.Remove(result);
          return dbContext.SaveChanges()>0;
        }

        public CustomerDto GetById(string id)
        {
           return dbContext.Customers.Where(x=>x.CustomerID==id).Select(c=> new CustomerDto
           {
                Address=c.Address,
                 ContactName=c.ContactName,
                  CustomerName=c.CompanyName,
                   Phone=c.Phone,   
           }).SingleOrDefault();                  
        }

        public PagedList<List<CustomerListDto>> GetPagedCustomer(int count, int page)
        {
            var data=dbContext.Customers.Skip((page - 1) * count).Take(count).Select(c=>new CustomerListDto
            {
                  Address = c.Address,
                  ContactName = c.ContactName,
                  CustomerName=c.CompanyName,
                  Phone = c.Phone,
                  CustomerId=c.CustomerID
            }).ToList();
            var totalCount = dbContext.Customers.Skip(page * count).Count();
            return new PagedList<List<CustomerListDto>>() {  Data=data ,TotalCount=totalCount };
        }
    }
}
