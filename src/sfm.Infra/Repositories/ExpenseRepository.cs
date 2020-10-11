using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using sfm.Domain.Interfaces.IExpense;
using sfm.Infra.Configurations;
using sfm.Entities.Entities;

namespace sfm.Infra.Repositories
{
    public class ExpenseRepository : GenericRepository<Expense>, IExpense
    {
        private readonly DbContextOptions<Context> _OptionsBuilder;

        public ExpenseRepository() { _OptionsBuilder = new DbContextOptions<Context>(); }

        public IList<Expense> ListUpaindUserExpensesFromThePreviewsMonth(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join c in db.Category on fs.Id equals c.SystemId
                    join su in db.SystemUser on fs.Id equals su.SystemId
                    join e in db.Expense on c.Id equals e.CategoryId
                    where su.UserEmail.Equals(userEmail) && e.Month < DateTime.Now.Month && !e.PaidOut
                    select e).AsNoTracking().ToList();
        }

        public IList<Expense> ListUserExpense(string userEmail)
        {
            using var db = new Context(_OptionsBuilder);
            return (from fs in db.FinancialSystem
                    join c in db.Category on fs.Id equals c.SystemId
                    join su in db.SystemUser on fs.Id equals su.SystemId
                    join e in db.Expense on c.Id equals e.CategoryId
                    where su.UserEmail.Equals(userEmail) && fs.Month == e.Month && fs.Year == e.Year
                    select e).AsNoTracking().ToList();
        }
    }
}
