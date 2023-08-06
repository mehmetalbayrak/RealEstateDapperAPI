using RealEstateDapperAPI.Dtos.CategoryDtos;

namespace RealEstateDapperAPI.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        void DeleteCategoryAsync(int id);
        void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
    }
}
