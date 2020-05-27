using System.Collections.Generic;
using BudgetApp_v11.Server.Services.Contract;
using BudgetApp_v11.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BudgetApp_v11.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BudgetController : ControllerBase
    {

        private readonly ILogger<BudgetController> logger;
        private readonly IBudgetService budgetService;

        public BudgetController(ILogger<BudgetController> logger, IBudgetService budgetService)
        {
            this.logger = logger;
            this.budgetService = budgetService;
        }

        [HttpGet]
        public IEnumerable<Budget> Get()
        {
            return budgetService.GetBudgets();
        }

        [HttpPost]
        public void Post(Budget budget)
        {
            budgetService.AddBudget(budget);
        }
    }
}
