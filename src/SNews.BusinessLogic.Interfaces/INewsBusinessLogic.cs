using SNews.BusinessModel.News;
using System;
using System.Collections.Generic;

namespace SNews.BusinessLogic.Interfaces
{
    public interface INewsBusinessLogic
    {
        List<GetNewsListResponse> GetNewsList(GetNewsListRequest request);
    }
}
