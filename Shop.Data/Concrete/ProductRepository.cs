using Microsoft.EntityFrameworkCore;
using Shop.Data.Abstract;
using Shop.Data.Context;
using Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task AddProductAsync(Product product)
        {
            if (product is not null)
            {
                if (
                    product.Id > 0 &&
                    product.Name is not null &&
                    product.Description is not null &&
                    product.Category is not null &&
                    product.Price > 0
                    )
                {
                    await _context.Products.AddAsync(product);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            if (id == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            var removingProduct = await _context.Products.FindAsync(id);

            if (removingProduct != null)
            {
                _context.Products.Remove(removingProduct);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            if (id == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            var product = await _context.Products.FindAsync(id);

            if (product is null)
            {
                throw new Exception();
            }

            return product;
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (product is not null)
            {
                if  (
                    product.Id > 0 &&
                    product.Name is not null &&
                    product.Description is not null &&
                    product.Category is not null &&
                    product.Price > 0
                    )
                {
                    await _context.Products
                        .Where(p => p.Id == product.Id)
                        .ExecuteUpdateAsync(p => p
                            .SetProperty(p => p.Name, product.Name)
                            .SetProperty(p => p.Description, product.Description)
                            .SetProperty(p => p.Category, product.Category)
                            .SetProperty(p => p.Price, product.Price));
                }
            }
        }
    }
}
