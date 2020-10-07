using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface IFinancialSystemService
    {
        void AddFinancialSystem(FinancialSystem financialSystem);
        void updateFinancialSystem(FinancialSystem financialSystem);
    }
}
