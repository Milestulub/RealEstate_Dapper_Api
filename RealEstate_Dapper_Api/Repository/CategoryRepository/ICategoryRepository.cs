using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>>GetAllCategoryAsync();
    }
}
