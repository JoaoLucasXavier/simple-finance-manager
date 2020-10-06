using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using sfm.Entities.Enums;

namespace sfm.Entities.Entities
{
    [Table("expense")]
    public class Expense : Base
    {
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Display(Name = "Mês")]
        public int Month { get; set; }

        [Display(Name = "Ano")]
        public int Year { get; set; }

        [Display(Name = "Tipo despesa")]
        public ExpensesType ExpenseType { get; set; }

        [Display(Name = "Data cadastro")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "Data alteração")]
        public DateTime ChangeDate { get; set; }

        [Display(Name = "Data pagamento")]
        public DateTime DatePayment { get; set; }

        [Display(Name = "Data vencimento")]
        public DateTime DateExpiration { get; set; }

        [Display(Name = "Pago")]
        public bool PaidOut { get; set; }

        [Display(Name = "Despesa atrasada")]
        public bool OverdueExpense { get; set; }

        [Display(Name = "Categoria")]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
