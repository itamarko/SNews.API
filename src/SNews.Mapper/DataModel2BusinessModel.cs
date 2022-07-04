using AutoMapper;
using SNews.BusinessModel.Author;
using SNews.BusinessModel.Category;
using SNews.BusinessModel.News;
using SNews.DataModel.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.Mapper
{
    public class DataModel2BusinessModel : Profile
    {
        public DataModel2BusinessModel()
        {
            this.CreateMap<GetNewsResponse, GetNewsListResponse>();
            this.CreateMap<DataModel.Categories.Category, Category>();
            this.CreateMap<DataModel.Author.Author, Author>();
        }
    }
}
