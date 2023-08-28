using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.Dtos.CategoryDtos;
using RealEstateDapperAPI.Dtos.WhoWeAreDetailDtos;
using RealEstateDapperAPI.Repositories.CategoryRepository;
using RealEstateDapperAPI.Repositories.WhoWeAreRepository;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAreDetailController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreRepository.CreateWhoWeAreDetailAsync(createWhoWeAreDetailDto);
            return Ok("Detay başarılı bir şekilde eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAreDetail(id);
            return Ok("Detay başarılı bir şekilde silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _whoWeAreRepository.UpdateWhoWeAreDetailAsync(updateWhoWeAreDetailDto);
            return Ok("Detay başarılı bir şekilde güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCWhoWeAreDetailById(int id)
        {
            var value = await _whoWeAreRepository.GetByIdWhoWeAreDetailAsync(id);
            return Ok(value);
        }
    }
}
