using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        [Remote("Index","Valid",ErrorMessage = "不得輸入今日以後之日期")]
        public DateTime PostTime { get; set; }

        [Required]
        [RegularExpression(@"^\+?[1-9][0-9]*$",ErrorMessage = "限定輸入正整數")]
        [DisplayFormat(DataFormatString = "{0:#,#}")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(100)]
        public string Remark { get; set; }
    }
}