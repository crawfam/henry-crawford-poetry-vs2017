using System.ComponentModel.DataAnnotations;

namespace Models{

    public class PantoumModel
    {
        [Display(Name = "Poem Title:")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Line1")]
        public string Line1 { get; set; }
        [Required]
        [Display(Name = "Line2")]
        public string Line2 { get; set; }
        [Required]
        [Display(Name = "Line3")]
        public string Line3 { get; set; }
        [Required]
        [Display(Name = "Line4")]
        public string Line4 { get; set; }
        [Required]
        [Display(Name = "Line5")]
        public string Line5 { get; set; }
        [Required]
        [Display(Name = "Line6")]
        public string Line6 { get; set; }
        [Required]
        [Display(Name = "Line7")]
        public string Line7 { get; set; }
        [Required]
        [Display(Name = "Line8")]
        public string Line8 { get; set; }
        [Required]
        [Display(Name = "Line9")]
        public string Line9 { get; set; }
        [Required]
        [Display(Name = "Line10")]
        public string Line10 { get; set; } 
    }


}