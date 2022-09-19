using System;
using System.Collections.Generic;

namespace TechnicalRadiation.Repositories.Entities
{
    public class CategoryNewsItem
    {
        public int CategoriesId { get; set; }
        public int NewsItemsId { get; set; }

        public Category Category { get; set; }
        public NewsItem NewsItem { get; set; }
    }
}