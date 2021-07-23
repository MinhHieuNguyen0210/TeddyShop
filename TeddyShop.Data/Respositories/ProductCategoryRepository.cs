using System.Collections.Generic;
using System.Linq;
using TeddyShop.Data.Infrastructure;
using TeddyShop.Model.Model;

namespace TeddyShop.Data.Respositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
              : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}