using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public class NewsRepository : INewsRepository
    {
        private List<News> _newsList;
        public NewsRepository()
        {
            _newsList = new List<News>(NewsBase.News);
        }

        public IEnumerable<News> GetAllNews()
        {
            return _newsList;
        }

        public News GetArticle(int id)
        {
            return _newsList.FirstOrDefault(article => article.Id == id);
        }
    }
}
