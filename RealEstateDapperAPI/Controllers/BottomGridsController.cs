using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapperAPI.Repositories.BottomGridRepositories;

namespace RealEstateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomRepository _bottomRepository;

        public BottomGridsController(IBottomRepository bottomRepository)
        {
            _bottomRepository = bottomRepository;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
    }
}
