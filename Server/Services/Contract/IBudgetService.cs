using BudgetApp_v11.Shared;
using System.Collections.Generic;

namespace BudgetApp_v11.Server.Services.Contract
{
    public interface IBudgetService
    {
        IList<Budget> GetBudgets();

        bool AddBudget(Budget budget);

        Budget GetBudgetDetails(int budgetId);
    }
}
