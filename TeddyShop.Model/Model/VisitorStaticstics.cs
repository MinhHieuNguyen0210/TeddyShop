using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyShop.Model.Model
{
    [Table("VisitorStatictics")]
    public class VisitorStaticstics
    {
        [Key]
        public Guid ID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }

        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}