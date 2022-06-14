using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNews.DataModel.News
{
    public class GetNewsResponse
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public int AuthorId { get; set; }
		public string AuthorFirstName { get; set; }
		public string AuthorLastname { get; set; }
		public DateTime Created { get; set; }
	}
}
