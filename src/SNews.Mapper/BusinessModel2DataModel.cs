using AutoMapper;
using SNews.BusinessModel.News;
using SNews.DataModel.News;
using System;

namespace SNews.Mapper
{
    public class BusinessModel2DataModel : Profile
    {
        public BusinessModel2DataModel()
        {
            this.CreateMap<GetNewsListRequest, GetNewsRequest>();
            this.CreateMap<GetNewsRequest, GetNewsListRequest>();
        }
    }
}
