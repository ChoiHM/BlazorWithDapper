using BlazorDapper.Core;
using BlazorDapper.Core.Dtos;
using BlazorDapper.DataAccess.Interface;

using Dapper;
using Dapper.Contrib.Extensions;

namespace BlazorDapper.DataAccess.Repositories
{
    public class ProductService : IProductService
    {
        private readonly DapperContext _context;
        public ProductService(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductDto>?> GetAll()
        {
            try
            {
                using (var conn = _context.CreateConnection())
                {
                    var sql = "SELECT * FROM tb_contract";
                    var books = await conn.QueryAsync<ProductDto>(sql);
                    return books;
                }
            }
            catch
            {
                return null;
            }
        }
        
        public async Task<bool> AddAsync(ProductDto product)
        {
            try
            {
                using (var conn = _context.CreateConnection())
                {
                    var result = await conn.InsertAsync(product);
                    return result > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(ProductDto product)
        {
            try
            {
                using (var conn = _context.CreateConnection())
                {
                    var result = await conn.UpdateAsync(product);
                    return result;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(ProductDto product)
        {
            try
            {
                using (var conn = _context.CreateConnection())
                {
                    var result = await conn.UpdateAsync(product);
                    return result;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}