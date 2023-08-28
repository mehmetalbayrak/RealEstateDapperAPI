using RealEstateDapperAPI.Dtos.CategoryDtos;
using RealEstateDapperAPI.Dtos.WhoWeAreDetailDtos;

namespace RealEstateDapperAPI.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetailAsync(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto updateCategoryDto);
        Task<GetByIdWhoWeAreDetailDto> GetByIdWhoWeAreDetailAsync(int id);
    }
}
