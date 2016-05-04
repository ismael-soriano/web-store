using Autofac;
using Core;
using Domain.Product;
using Domain.Ticket;

namespace WebStoreWcf.Configurations
{
    public class Core
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<TicketService>().As<ITicketService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ShopDbContext>().As<IRepositoryTicket>().As<IRepositoryProduct>();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}