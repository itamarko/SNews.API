using Dapper;
using Microsoft.Extensions.Configuration;
using SNews.DataModel.Categories;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IConfiguration _config;
        private readonly string _connString;

        public CategoryService(IConfiguration configuration)
        {
            _config = configuration;
            _connString = _config.GetConnectionString("SasaNews");
        }

        public List<Category> GetCategories()
        {
            List<Category> response = new List<Category>();
            try
            {
                string query = "GetCategories";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<Category>(query,
                                                        commandType: System.Data.CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception ex)
            {
                response = null;
                //todo log error
            }
            return response;
        }

        public Category GetCategoryById(int id)
        {
            Category response = new Category();
            try
            {
                string query = "GetCategoryById";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<Category>(query,
                                                        new { Id = id },
                                                        commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                response = null;
                //todo log error
            }
            return response;
        }

        public Category InsertCategory(InsertCategoryRequest category)
        {
            Category response = new Category();
            try
            {
                string query = "InsertCategory";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<Category>(query,
                                                        category,
                                                        commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                response = null;
                //todo log error
            }
            return response;
        }
    }
}
