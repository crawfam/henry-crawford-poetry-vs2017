using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class SestinaModel
    {
        
        [Display(Name = "Poem Title:")]        
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "A")]
        public string LineEnding1 { get; set; }
        [Required]
        [Display(Name = "B")]
        public string LineEnding2 { get; set; }
        [Required]
        [Display(Name = "C")]
        public string LineEnding3 { get; set; }
        [Required]
        [Display(Name = "D")]
        public string LineEnding4 { get; set; }
        [Required]
        [Display(Name = "E")]
        public string LineEnding5 { get; set; }
        [Required]
        [Display(Name = "F")]
        public string LineEnding6 { get; set; }
    }    
}