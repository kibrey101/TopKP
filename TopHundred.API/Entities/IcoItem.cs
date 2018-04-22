using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopHundred.API.Entities
{
    public enum IcoTypeEnumeration { PreIco = 1000, ActiveIco, UpcomingIco, PastIco }
    public class IcoItem
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string PriceCurrency{ get; set; }
        [Required, MaxLength(10)]
        public string Symbol { get; set; }
        [Required]
        public string IconLink { get; set; }
        [Required]
        public IcoTypeEnumeration IcoTypeEnumeration { get; set; }  
        [Required, MaxLength(20)]
        public string Status { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string WhitePaper { get; set; }
        public User User { get; set; }
        public int TotalTokenCount { get; set; }
        public int Rank { get; set; }          
        public IEnumerable<IcoLink> IcoLinks { get; set; } = new List<IcoLink>();

    }
}
