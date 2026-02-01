using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Application.DTO_s
{
    public class CreateItemDTO
    {
        public string? Title { get; set; }
        public decimal Amount { get; set; }
    }
}
