using System.Collections.Generic;

namespace BudgetApp_v11.Shared
{
    public class Purpose
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal FinallyValue { get; set; }
        public IList<InOut> InOutComings { get; set; }
    }
}
