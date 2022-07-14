using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel;
using SNews.BusinessModel.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorBusinessLogic _authorBusinessLogic;

        public AuthorsController(IAuthorBusinessLogic authorBusinessLogic)
        {
            _authorBusinessLogic = authorBusinessLogic;
        }

        [HttpPost]
        public IActionResult Post(InsertAuthorRequest author)
        {
            var result = _authorBusinessLogic.InsertAuthor(author);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            CommandResponse<List<Author>> result = new CommandResponse<List<Author>>();
            try
            {
                result = _authorBusinessLogic.GetAuthors();
            }
            catch(Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            CommandResponse<Author> result = new CommandResponse<Author>();
            try
            {
                result = _authorBusinessLogic.GetAuthorById(id);
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }

            return Ok(result);
        }
    }
}
