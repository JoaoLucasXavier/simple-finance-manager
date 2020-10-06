using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.Entities
{
    [Table("purchaseItem")]
    public class PurchaseItem : Base
    {
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Display(Name = "Comprado")]
        public bool Purchased { get; set; }

        [Display(Name = "Data cadastro")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Data alteração")]
        public DateTime ChangeDate { get; set; }

        [Display(Name = "Data compra")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Compra")]
        [ForeignKey("Purchase")]
        public Guid PurchaseId { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}
