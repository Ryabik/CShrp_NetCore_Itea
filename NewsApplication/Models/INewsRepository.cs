using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public interface INewsRepository
    {
        News GetArticle(int id);
        IEnumerable<News> GetAllNews();
    }
}
