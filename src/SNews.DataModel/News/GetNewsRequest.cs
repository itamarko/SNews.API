using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.DataModel.News
{
    public class GetNewsRequest
    {
        public int? AuthorId { get; set; }
        public int? TagId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public string Title { get; set; }
    }
}
