﻿using Dapper;
using RealEstateDapperAPI.Dtos.CategoryDtos;
using RealEstateDapperAPI.Dtos.ProductDtos;
using RealEstateDapperAPI.Models.DapperContext;

namespace RealEstateDapperAPI.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetResultProductWithCategoryAsync()
        {
            string query = "Select ProductId,Title,Price,City,District,CategoryName,Address,Type,CoverImage from Product inner join Category on Product.ProductCategory = Category.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
