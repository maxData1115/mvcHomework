using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcHomework1.ViewModels
{
    public class MoenyRecordViewModel
    {
        public List<string> IncomeExpense { get; set; }
        public List<DateTime> PostTime { get; set; }
        public List<int> Amount { get; set; }
    }
}