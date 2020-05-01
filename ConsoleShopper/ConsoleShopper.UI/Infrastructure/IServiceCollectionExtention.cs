using ConsoleShopper.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleShopper.UI
{
    // Creates an extention method for IServiceCollection, keyword 'this' in the parameter makes it an extention 
    public static class IServiceCollectionExtension
    {
        //public static IServiceCollection AddServiceLayerServices(this IServiceCollection services)
        //{
        //    services.AddTransient<ICustomerService, CustomerService>();
        //    return services;
        //}

        public static IServiceCollection AddRepositoryLayerServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
