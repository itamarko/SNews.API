using SNews.DataModel.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.Services.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();
        Author GetAuthorById(int id);
        Author InsertAuthor(InsertAuthorRequest request);
    }
}
