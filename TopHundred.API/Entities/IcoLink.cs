using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopHundred.API.Entities
{
    public enum SocialMeidaLinksEnumeration { Facebook = 0, Twitter, Website, Instagram, Medium, Other }
    public class IcoLink
    {
        public Guid Id { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
        public SocialMeidaLinksEnumeration LinkIcon { get; set; }
        [ForeignKey("IcoItemId")]
        public IcoItem IcoItem { get; set; }
        public Guid IcoItemId { get; set; }
    }
}
