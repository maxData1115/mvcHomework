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
        [Required]
        public IncomeExpenseEnums IncomeExpense { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PostTime { get; set; }

        [Required]     
        public Decimal Amount { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
    }
}