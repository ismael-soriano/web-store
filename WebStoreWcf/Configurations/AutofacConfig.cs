using Autofac;
using Domain;

namespace WebStoreWcf.Configurations
{
    public class AutofacConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<InvoiceService>().As<IInvoiceService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ShopDbContext>().As<IRepositoryInvoices>();
            builder.RegisterType<ShopDbContext>().As <IRepositoryProducts>();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}