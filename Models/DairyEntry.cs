using System.ComponentModel.DataAnnotations;

namespace MyApplication3.Models
{
    public class DairyEntry
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Please Enter the Title")]
        //[StringLength(1000,MinimumLength =3,ErrorMessage ="Title is between 1000 and 3")]            
        public string Title { get; set; }= string.Empty;
       
        [Required(ErrorMessage = "Please Enter the Content")]
        public string Content { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please Enter the Date")]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
