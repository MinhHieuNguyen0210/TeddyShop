using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeddyShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeddyShopDbContext dbContext;

        public TeddyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeddyShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
