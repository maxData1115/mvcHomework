using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using mvcHomework1.Enum;
using Microsoft.SqlServer.Server;

namespace mvcHomework1.ViewModels
{
    public class MoneyRecordViewModel
    {
        public IncomeExpenseEnums IncomeExpense { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PostTime { get; set; }
        public Decimal Amount { get; set; }
        public string Remark { get; set; }
    }
}