using Dapper;
using RealEstateDapperAPI.Dtos.CategoryDtos;
using RealEstateDapperAPI.Dtos.TestimonialDtos;
using RealEstateDapperAPI.Models.DapperContext;

namespace RealEstateDapperAPI.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync()
        {
            string query = "Select * from Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }
    }
}
