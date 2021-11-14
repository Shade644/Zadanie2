using System.ComponentModel.DataAnnotations;

namespace Zadanie2.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        public int Number { get; set; }
    }
}
