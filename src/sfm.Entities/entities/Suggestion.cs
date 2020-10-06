using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.Entities
{
    [Table("suggestion")]
    public class Suggestion : Base
    {
        [Display(Name = "Sugestão")]
        public string DescriptionSuggestion { get; set; }

        [Display(Name = "E-mail usuário")]
        public string UserEmail { get; set; }
    }
}
