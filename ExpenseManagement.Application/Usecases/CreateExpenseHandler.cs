using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagement.Application.DTO_s;
using ExpenseManagement.Application.Interfaces;
using ExpenseManagement.Domain.Entities;

namespace ExpenseManagement.Application.Usecases
{
    public class CreateExpenseHandler
    {
        private readonly IExpenseRepository _repository;

        public CreateExpenseHandler(IExpenseRepository repository)
        {
            _repository = repository;
        }

        public async Task<Expense> Handle(string tenantid, CreateItemDTO dto)
        {
            var expense = new Expense(tenantid, dto.Title!, dto.Amount);
            await _repository.AddAsync(expense);
            return expense;
        } 
    }
}
