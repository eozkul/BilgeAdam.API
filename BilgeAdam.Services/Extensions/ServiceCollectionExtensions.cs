using BilgeAdam.Services.Abstractions;
using BilgeAdam.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace BilgeAdam.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            //services.AddScoped<ISupplierService, SupplierServiceForMongoDb>();
        }
    }
}