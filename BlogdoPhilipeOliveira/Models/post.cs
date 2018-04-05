using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BlogdoPhilipeOliveira.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        [Required]
        [StringLength(3000)]
        [AllowHtml]
        public string PostingBody { get; set; }
        public byte[] Image { get; set; }
    }
}



