using System;
using sfm.Domain.Interfaces.IFinancialSystem;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class FinancialSystemService : IFinancialSystemService
    {
        private readonly IFinancialSystem _iFinancialSystem;

        public FinancialSystemService(IFinancialSystem iFinancialSystem)
        {
            _iFinancialSystem = iFinancialSystem;
        }

        public void AddFinancialSystem(FinancialSystem financialSystem)
        {
            var valid = financialSystem.ValidateStringProperty(financialSystem.Name, "Name");
            if (valid)
            {
                var data = DateTime.Now;
                financialSystem.ClosingDay = 1;
                financialSystem.Year = data.Year;
                financialSystem.Month = data.Month;
                financialSystem.YearCopy = data.Year;
                financialSystem.CopyMonth = data.Month;
                financialSystem.GenerateCopyExpenses = true;
                _iFinancialSystem.Add(financialSystem);
            }
        }

        public void updateFinancialSystem(FinancialSystem financialSystem)
        {
            var valid = financialSystem.ValidateStringProperty(financialSystem.Name, "Name");
            if (valid)
            {
                financialSystem.ClosingDay = 1;
                _iFinancialSystem.Update(financialSystem);
            }
        }
    }
}
