using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Required]
        public string Content { get; set; }

        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
    }   
}