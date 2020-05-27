using System;

namespace BudgetApp_v11.Shared
{
    public class InOut
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public InOutType Type { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
