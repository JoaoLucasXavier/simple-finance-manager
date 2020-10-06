using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.Entities
{
    [Table("category")]
    public class Category : Base
    {
        [Display(Name = "Código sistema")]
        [ForeignKey("FinancialSystem")]
        public Guid SistemId { get; set; }

        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
