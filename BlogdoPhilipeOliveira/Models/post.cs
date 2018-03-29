using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlogdoPhilipeOliveira.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime Dateupdated { get; set; }
        [Required]
        [StringLength(500)]
        public string PostingBody { get; set; }
    }
}