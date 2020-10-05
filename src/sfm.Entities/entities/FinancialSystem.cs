using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.entities
{
    [Table("SistemaFinanceiro")]
    public class FinancialSystem : Base
    {
        [Display(Name = "Ano sistema")]
        public int Year { get; set; }

        [Display(Name = "Mês sistema")]
        public int Month { get; set; }

        [Display(Name = "Dia início mês")]
        public int ClosingDay { get; set; }

        [Display(Name = "Gerar cópia das despesas")]
        public bool GenerateCopyExpenses { get; set; }

        [Display(Name = "Mês cópia")]
        public int CopyMonth { get; set; }

        [Display(Name = "Ano cópia")]
        public int YearCopy { get; set; }
    }
}
