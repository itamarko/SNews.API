using Dapper;
using Microsoft.Extensions.Configuration;
using SNews.DataModel.News;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SNews.Services
{
    public class NewsService : INewsService
    {
        private readonly IConfiguration _config;
        private readonly string _connString;

        public NewsService(IConfiguration configuration)
        {
            _config = configuration;
            _connString = _config.GetConnectionString("SasaNews");
        }

        public void EditNews()
        {
            throw new NotImplementedException();
        }

        public List<GetNewsResponse> GetNews(GetNewsRequest request)
        {
            List<GetNewsResponse> response = new List<GetNewsResponse>();
            try
            {
                string query = "GetNewsList";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<GetNewsResponse>(query,
                                                            request,
                                                            commandType: System.Data.CommandType.StoredProcedure).AsList();
                }
            }
            catch(Exception ex)
            {

            }
            return response;
        }

        public void InsertNews()
        {
            throw new NotImplementedException();
        }
    }
}
