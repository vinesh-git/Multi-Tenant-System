using ExpenseManagement.Application.DTO_s;
using ExpenseManagement.Application.Usecases;
using ExpenseManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagement.Api.Controllers
{
    [ApiController]
    [Route("api/expenses")]
    public class ExpensesController : ControllerBase
    {
        private readonly CreateExpenseHandler _handler;

        public ExpensesController(CreateExpenseHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateItemDTO dto)
        {
            var tenantId = "jwt-token";
            var expense = await _handler.Handle(tenantId, dto);
            return Ok(expense);

        }
    }
}
