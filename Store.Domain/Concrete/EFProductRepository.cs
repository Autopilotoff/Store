using System.Linq;
using Store.Domain.Abstract;
using Store.Domain.Entities;
using System.Data.Entity;

namespace Store.Domain.Concrete
{

    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
    public class EFDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}