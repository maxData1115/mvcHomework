using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.ViewModels;
using mvcHomework1.Service;
using mvcHomework1.Enum;

namespace mvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        AccountBookService accountBooksService;

        public ActionResult Index()
        {
            return View(new MyEnum());
        }

        [ChildActionOnly]
        public ActionResult IndexChildAction()
        {
            accountBooksService= new AccountBookService();
            List<MoneyRecordViewModel> recordList = new List<MoneyRecordViewModel>();
            var items = accountBooksService.GetTopNAccount(100);

            recordList = items.Select(d => new MoneyRecordViewModel
            {
                //IncomeExpense = d.Categoryyy == 0 ? "支出" : "收入",
                IncomeExpense = (IncomeExpenseEnums)d.Categoryyy,
                PostTime = d.Dateee,
                Amount = d.Amounttt,
            }).ToList();

            return View(recordList);
        }

        public ActionResult AddRecord(IncomeExpenseEnums category, decimal money, DateTime date,string description)
        {
            return Content("YES");
        }
    }
}