using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Url]
        public string ImgSource { get; set; }
        [MaxLength(255)]
        public string Bio { get; set; }
        
    }
}