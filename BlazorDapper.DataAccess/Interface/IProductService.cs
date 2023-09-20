using BlazorDapper.Core.Dtos;

namespace BlazorDapper.DataAccess.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>?> GetAll();
        Task<bool> AddAsync(ProductDto product);
        Task<bool> DeleteAsync(ProductDto product);
        Task<bool> UpdateAsync(ProductDto product);
    }
}