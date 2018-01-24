using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.ViewModels;
using mvcHomework1.Models.Domain;
using mvcHomework1.Models.Repository;

namespace mvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        AccountBooksRepository accountBooksRepository;

        public HomeController()
        {
            this.accountBooksRepository = new AccountBooksRepository();
        }

        public ActionResult Index()
        {
            List<MoneyRecordViewModel> recordList = new List<MoneyRecordViewModel>();
            var items = accountBooksRepository.GetAccount();

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