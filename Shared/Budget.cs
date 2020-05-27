using System.Collections.Generic;

namespace BudgetApp_v11.Shared
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CurrentValue { get; set; }
        //public IList<MonthlyState> MontlyStates { get; set; }
        public IList<Purpose> Purposes { get; set; }

    }
}
