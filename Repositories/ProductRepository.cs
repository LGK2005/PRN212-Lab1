using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO _productDAO = new ProductDAO();

        public void DeleteProduct(Product p) => _productDAO.DeleteProduct(p);
        public List<Product> GetProducts() => ProductDAO.GetProducts();
        public Product GetProductById(int id) => _productDAO.GetProductById(id);
        public void SaveProduct(Product p) => _productDAO.SaveProduct(p);
        public void UpdateProduct(Product p) => _productDAO.UpdateProduct(p);
    }
}
