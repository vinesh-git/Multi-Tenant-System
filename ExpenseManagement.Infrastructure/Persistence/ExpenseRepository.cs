using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagement.Application.Interfaces;
using ExpenseManagement.Domain.Entities;

namespace ExpenseManagement.Infrastructure.Persistence
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _dbContext;

        public ExpenseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Expense expense)
        {
            if (expense == null) throw new Exception("Invalid Expense");
            _dbContext.Expenses.Add(expense);
            await _dbContext.SaveChangesAsync();
        }
    }
}
