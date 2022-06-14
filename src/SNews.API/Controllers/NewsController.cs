using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsBusinessLogic _newsBusinessLogic;

        public NewsController(INewsBusinessLogic newsBusinessLogic)
        {
            _newsBusinessLogic = newsBusinessLogic;
        }

        [HttpPost]
        public IActionResult GetNewsList(GetNewsListRequest request)
        {
            var result = _newsBusinessLogic.GetNewsList(request);
            return Ok(result);
        }
    }
}
