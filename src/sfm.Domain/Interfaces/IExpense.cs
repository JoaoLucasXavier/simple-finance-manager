using System.Collections.Generic;
using sfm.Entities.Entities;

namespace sfm.Domain.Interfaces
{
    public interface IExpense : IGeneric<Expense>
    {
        IList<Expense> ListUserExpense(string userEmail);
        IList<Expense> ListUpaindUserExpensesFromThePreviewsMonth(string userEmail);
    }
}
