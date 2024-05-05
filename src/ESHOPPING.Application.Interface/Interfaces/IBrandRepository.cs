using ESHOPPING.Domain.Entities;

namespace ESHOPPING.Application.Interface.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<ProductBrand>> GetAllBrands();
    }
}
