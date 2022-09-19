using System;
using System.Collections.Generic;

namespace TechnicalRadiation.Repositories.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImgSource { get;  set; }
        public string Bio { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Navigation properties
        public ICollection<AuthorNewsItem> AuthorNewsItem { get; set; }

        public ICollection<CategoryNewsItem> CategoryNewsItem { get; set; }
    }
}