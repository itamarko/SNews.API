using AutoMapper;
using SNews.BusinessLogic.Interfaces;
using SNews.BusinessModel.News;
using SNews.DataModel.News;
using SNews.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace SNews.BusinessLogic
{
    public class NewsBusinessLogic : INewsBusinessLogic
    {
        private readonly IMapper _mapper;
        private readonly INewsService _newsService;

        public NewsBusinessLogic(IMapper mapper, INewsService newsService)
        {
            _mapper = mapper;
            _newsService = newsService;
        }
        public List<GetNewsListResponse> GetNewsList(GetNewsListRequest request)
        {
            List<GetNewsListResponse> result = new List<GetNewsListResponse>();

            GetNewsRequest serviceRequest = _mapper.Map<GetNewsRequest>(request);
            var serviceResponse = _newsService.GetNews(serviceRequest);
            result = _mapper.Map<List<GetNewsListResponse>>(serviceResponse);

            return result;
        }
    }
}
