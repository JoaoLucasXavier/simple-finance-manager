using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.Entities
{
    [Table("systemUser")]
    public class SystemUser
    {
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        public SystemUser()
        {
            Id = Guid.NewGuid();
        }

        [Display(Name = "E-mail usuário")]
        public string UserEmail { get; set; }

        [Display(Name = "Administrador")]
        public bool Administrator { get; set; }

        [Display(Name = "Sistema atual")]
        public bool CurrentSystem { get; set; }

        [Display(Name = "Código sistema")]
        [ForeignKey("FinancialSystem")]
        public Guid SystemId { get; set; }

        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
