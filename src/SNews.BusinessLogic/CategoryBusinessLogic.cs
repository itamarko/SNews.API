using AutoMapper;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel;
using SNews.BusinessModel.Category;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.BusinessLogic
{
    public class CategoryBusinessLogic : ICategoryBusinessLogic
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryBusinessLogic(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public CommandResponse<List<Category>> GetCategories()
        {
            CommandResponse<List<Category>> result = new CommandResponse<List<Category>>();
            try
            {
                var categoryDM = _categoryService.GetCategories();
                if (categoryDM != null)
                {
                    result.Data = _mapper.Map<List<Category>>(categoryDM);
                }
                else
                {
                    result.ErrorMessage = Resources.Resources.errServiceError;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = Resources.Resources.generalError;
                //todo log error
            }
            return result;
        }

        public CommandResponse<Category> GetCategoryById(int id)
        {
            CommandResponse<Category> result = new CommandResponse<Category>();
            try
            {
                var categoryDM = _categoryService.GetCategoryById(id);
                if (categoryDM != null)
                {
                    result.Data = _mapper.Map<Category>(categoryDM);
                }
                else
                {
                    result.ErrorMessage = Resources.Resources.errServiceError;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = Resources.Resources.generalError;
                //todo log error
            }
            return result;
        }

        public CommandResponse<Category> InsertCategory(InsertCategoryRequest request)
        {
            CommandResponse<Category> result = new CommandResponse<Category>();
            try
            {
                var requestDM = _mapper.Map<DataModel.Categories.InsertCategoryRequest>(request);
                var categoryDM = _categoryService.InsertCategory(requestDM);
                if (categoryDM != null)
                {
                    result.Data = _mapper.Map<Category>(categoryDM);
                }
                else
                {
                    result.ErrorMessage = Resources.Resources.errServiceError;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = Resources.Resources.generalError;
                //todo log error
            }
            return result;
        }
    }
}
