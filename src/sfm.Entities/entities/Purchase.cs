using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.entities
{
    [Table("purchase")]
    public class Purchase : Base
    {
        [Display(Name = "Data cadastro")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Data alteração")]
        public DateTime ChangeDate { get; set; }

        [Display(Name = "Categoria")]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
