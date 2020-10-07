using System;
using sfm.Domain.Interfaces;
using sfm.Entities.Entities;

namespace sfm.Domain.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpense _iExpense;

        public ExpenseService(IExpense iExpense)
        {
            _iExpense = iExpense;
        }

        public void AddExpense(Expense expense)
        {
            expense.RegisterDate = DateTime.Now;
            expense.Year = DateTime.Now.Year;
            expense.Month = DateTime.Now.Month;
            var valid = expense.ValidateStringProperty(expense.Name, "Name");
            if (valid) _iExpense.Add(expense);
        }

        public void updateExpense(Expense expense)
        {
            expense.ChangeDate = DateTime.Now;
            if (expense.PaidOut) expense.DatePayment = DateTime.Now;
            var valid = expense.ValidateStringProperty(expense.Name, "Name");
            if (valid) _iExpense.Update(expense);
        }
    }
}
