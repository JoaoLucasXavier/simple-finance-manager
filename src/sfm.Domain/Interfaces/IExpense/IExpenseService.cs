using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces.IExpense
{
    public interface IExpenseService
    {
        void AddExpense(Expense expense);
        void updateExpense(Expense expense);
    }
}
