using Dapper;
using Microsoft.Extensions.Configuration;
using SNews.DataModel.Author;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IConfiguration _config;
        private readonly string _connString;

        public AuthorService(IConfiguration configuration)
        {
            _config = configuration;
            _connString = _config.GetConnectionString("SasaNews");
        }
        public Author InsertAuthor(InsertAuthorRequest author)
        {
            Author response = new Author();
            try
            {
                string query = "InsertAuthor";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<Author>(query,
                                                        author,
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
