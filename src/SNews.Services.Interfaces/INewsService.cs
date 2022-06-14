using SNews.DataModel.News;
using System;
using System.Collections.Generic;

namespace SNews.Services.Interfaces
{
    public interface INewsService
    {
        List<GetNewsResponse> GetNews(GetNewsRequest request);
        void EditNews();
        void InsertNews();
    }
}
