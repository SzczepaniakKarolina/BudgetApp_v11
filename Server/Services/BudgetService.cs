using BudgetApp_v11.Server.Data;
using BudgetApp_v11.Server.Services.Contract;
using BudgetApp_v11.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BudgetApp_v11.Server.Services
{
    public class BudgetService : IBudgetService
    {
        private ApplicationDbContext context;

        public BudgetService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool AddBudget(Budget budget)
        {
            context.Budgets.Add(budget);
            var result = Save();
            return result;
        }

        public Budget GetBudgetDetails(int budgetId)
        {
            return context.Budgets
                .Where(b => b.Id == budgetId)
                .Include(t => t.Purposes)
                .FirstOrDefault();

        }

        public IList<Budget> GetBudgets()
        {
            return context.Budgets.ToList();
        }

        private bool Save()
        {
            return context.SaveChanges() == 1;
        }
    }
}
