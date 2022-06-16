using SNews.BusinessModel;
using SNews.BusinessModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.BusinessLogic.Interfaces
{
    public interface ICategoryBusinessLogic
    {
        CommandResponse<List<Category>> GetCategories();
        CommandResponse<Category> GetCategoryById(int id);
        CommandResponse<Category> InsertCategory(InsertCategoryRequest request);
    }
}
