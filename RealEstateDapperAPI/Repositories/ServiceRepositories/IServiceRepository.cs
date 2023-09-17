using RealEstateDapperAPI.Dtos.CategoryDtos;
using RealEstateDapperAPI.Dtos.ServiceDtos;

namespace RealEstateDapperAPI.Repositories.ServiceRepositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateServiceAsync(CreateServiceDto createServiceDto);
        void DeleteServiceAsync(int id);
        void UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetByIdService(int id);
    }
}
