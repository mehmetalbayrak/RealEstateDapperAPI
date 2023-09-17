using RealEstateDapperAPI.Dtos.BottomGridDtos;
using RealEstateDapperAPI.Dtos.ServiceDtos;

namespace RealEstateDapperAPI.Repositories.BottomGridRepositories
{
    public interface IBottomRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateServiceAsync(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
