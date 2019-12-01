using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        [Required]
        public string Alias { get; set; }
        public string Content { get; set; }
        //public string MetaDescription { get; set; }

        //public string MetaKeyword { get; set; }
        //public bool Status { get; set; }
    }
}