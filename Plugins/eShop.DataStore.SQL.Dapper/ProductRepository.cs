using TruongDucThanh_K54.CoreBusiness.Model;
using TruongDucThanh_K54.DataStore.HardCodes.Helper;
using TruongDucThanh_K54.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.DataStore.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            this.dataAccess= dataAccess;
        }
        public IEnumerable<Product> GetProduct(string filter)
        {
            List<Product> list;
            if (string.IsNullOrWhiteSpace(filter))
            {
                list = dataAccess.Query<Product, dynamic>("select * from Product", new { });
            }
            else
            {
                list = dataAccess.Query<Product, dynamic>("select * from Product where Name like '%' + @Filter + '%'", new { Filter = filter });
            }

            return list.AsEnumerable();
        }

        public Product GetProductById(int id)
        {
            return dataAccess.QuerySingle<Product, dynamic>("select * from Product where ProductId = @ProductId", new { Id = id });
        }
    }
}
