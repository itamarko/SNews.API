using AutoMapper;
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
        }
    }
}
