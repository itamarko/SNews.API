using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryBusinessLogic _categoryBusinessLogic;

        public CategoriesController(ICategoryBusinessLogic categoryBusinessLogic)
        {
            _categoryBusinessLogic = categoryBusinessLogic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _categoryBusinessLogic.GetCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _categoryBusinessLogic.GetCategoryById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(InsertCategoryRequest category)
        {
            var result = _categoryBusinessLogic.InsertCategory(category);
            return Ok(result);
        }
    }
}
