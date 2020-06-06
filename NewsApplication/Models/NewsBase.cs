using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public static class NewsBase 
    {

        public static List<News> News = new List<News>
        {
            new News { Id = 0, Title = "Humanity finally colonized the Mercury!!", Text = "_bla-bla-bla...", AuthorName = "Jeremy Clarkson", IsFake = true},
            new News { Id = 1, Title = "Increase your lifespan by 10 years, every morning you need...", Text = "!!_bla-bla-bla...!!!!", AuthorName = "Svetlana Sokolova", IsFake = true},
            new News { Id = 2, Title = "Scientists estimed the time of the vaccine invension: it is a summer of 2021", Text = "--- ...bla-bla-bla...", AuthorName = "John Jones", IsFake = false},
            new News { Id = 3, Title = "Ukraine reduces the cost of its obligations!", Text = "...it's all about news...", AuthorName = "Cerol Denvers", IsFake = false},
            new News { Id = 4, Title = "A species were discovered in Africa: it is blue legless cat", Text = "---+++_bla-bla-bla...", AuthorName = "Jimmy Felon", IsFake = true}
        };
       
    }
}
