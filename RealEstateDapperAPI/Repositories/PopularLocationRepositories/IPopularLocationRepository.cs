using RealEstateDapperAPI.Dtos.BottomGridDtos;
using RealEstateDapperAPI.Dtos.PopularLocationDtos;

namespace RealEstateDapperAPI.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync();
        //void CreateServiceAsync(CreateBottomGridDto createBottomGridDto);
        //void DeleteBottomGridAsync(int id);
        //void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        //Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
