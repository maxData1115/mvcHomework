using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcHomework1.ViewModels
{
    public class MoneyRecordViewModel
    {
        public string IncomeExpense { get; set; }
        public DateTime PostTime { get; set; }
        public Decimal Amount { get; set; }
    }
}