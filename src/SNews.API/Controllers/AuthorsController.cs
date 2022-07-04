using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNews.BusinessLogic.Interfaces;
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
    }
}
