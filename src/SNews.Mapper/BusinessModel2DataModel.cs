using AutoMapper;
using SNews.BusinessModel.Author;
using SNews.BusinessModel.Category;
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
            this.CreateMap<InsertCategoryRequest, DataModel.Categories.InsertCategoryRequest>();
            this.CreateMap<InsertAuthorRequest, DataModel.Author.InsertAuthorRequest>();
        }
    }
}
