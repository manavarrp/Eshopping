using ESHOPPING.Domain.Entities;

namespace ESHOPPING.Application.Interface.Interfaces
{
    public interface ITypesRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();
    }
}
