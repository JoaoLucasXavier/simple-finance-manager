using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface IExpenseService
    {
        void AddExpense(Expense expense);
        void updateExpense(Expense expense);
    }
}
