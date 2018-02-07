using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.ViewModels;
using mvcHomework1.Service;
using mvcHomework1.Enum;
using System.Threading;

namespace mvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        AccountBookService accountBooksService;

        public HomeController()
        {
            this.accountBooksService=new AccountBookService();
        }

        public ActionResult Index()
        {
            MoneyRecordViewModel viewModel=new MoneyRecordViewModel();
            viewModel.PostTime = DateTime.Now;
       
            return View(viewModel);
        }

        [ChildActionOnly]
        public ActionResult IndexChildAction()
        {
            List<MoneyRecordViewModel> recordList = new List<MoneyRecordViewModel>();
            var items = accountBooksService.GetTopNAccount(100);

            recordList = items.Select(d => new MoneyRecordViewModel
            {
                IncomeExpense = (IncomeExpenseEnums)d.Categoryyy,
                PostTime = d.Dateee,
                Amount = d.Amounttt,
                Remark = d.Remarkkk
            }).ToList();

            return View(recordList);
        }

        public ActionResult IndexAjax()
        {
            List<MoneyRecordViewModel> recordList = new List<MoneyRecordViewModel>();
            var items = accountBooksService.GetTopNAccount(100);

            recordList = items.Select(d => new MoneyRecordViewModel
            {
                IncomeExpense = (IncomeExpenseEnums)d.Categoryyy,
                PostTime = d.Dateee,
                Amount = d.Amounttt,
                Remark = d.Remarkkk
            }).ToList();
            return View(recordList);
        }

        [HttpPost]
        public ActionResult AddRecord(MoneyRecordViewModel data)
        {
            if (ModelState.IsValid)
            {
                Guid id = Guid.NewGuid();
                accountBooksService.AddNewAccount(id,data);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", data);
        }
    }
}