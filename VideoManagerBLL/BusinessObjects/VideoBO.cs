using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VideoManagerBLL.BusinessObjects
{
    public class VideoBO
    {
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string VideoName { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }
        
    }

}
