using System;

namespace TechnicalRadiation.Models.Dtos
{
    public class NewsItemDetailDto
    {
        /// <summary>
        /// Id of the album
        /// </summary>
        /// <value>A number</value>
        public int Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// The published date of the album
        /// </summary>
        /// <value>Published date as date</value>
        public string ImgSource { get; set; }

        public string ShortDescription { get; set; }

        
        public string LongDescription { get; set; }
        public DateTime PublishDate { get; set; }
        
    }
}