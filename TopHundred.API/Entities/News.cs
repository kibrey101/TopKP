using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopHundred.API.Entities
{
    public class News
    {
        public Guid Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(350)]
        public string HighLight { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        public string HighLightImage { get; set; }
        public string ContentImage { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }  
        public string AuthorImage { get; set; }
    }
}
