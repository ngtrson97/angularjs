﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    [Table("PostCategories")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

    }
}
