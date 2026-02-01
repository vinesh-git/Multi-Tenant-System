using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagement.Domain.Enums;

namespace ExpenseManagement.Domain.Entities
{
    public class Expense
    {
        public Guid Id { get; private set; }
        public string TenantId { get; private set; }
        public string Title { get; private set; }
        public decimal Amount { get; private set; }
        public ExpenseStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private Expense() { }
        public Expense(string tenantid, string title , decimal amount) {
            Id = Guid.NewGuid();
            TenantId = tenantid;
            Title = title;
            Amount = amount;
            Status = ExpenseStatus.Pending;
            CreatedAt = DateTime.UtcNow.Date;
        }



    }
}
