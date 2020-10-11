using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.IFinancialSystem
{
    public interface IFinancialSystemService
    {
        void AddFinancialSystem(FinancialSystem financialSystem);
        void updateFinancialSystem(FinancialSystem financialSystem);
    }
}
