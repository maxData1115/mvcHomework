using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.ViewModels;
using mvcHomework1.Service;

namespace mvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        AccountBookService accountBooksService;

        public HomeController()
        {
            this.accountBooksService = new AccountBookService();
        }

        public ActionResult Index()
        {
            List<MoneyRecordViewModel> recordList = new List<MoneyRecordViewModel>();
            var items = accountBooksService.GetTopNAccount(100);

            foreach (var item in items)
            {
                MoneyRecordViewModel viewModel = new MoneyRecordViewModel();
                viewModel.IncomeExpense = item.Categoryyy == 0 ? "支出" : "收入";
                viewModel.PostTime = item.Dateee;
                viewModel.Amount = item.Amounttt;

                recordList.Add(viewModel);
            }
            return View(recordList);
        }
    }
}