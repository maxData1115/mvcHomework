using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.ViewModels;

namespace mvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> myFakeIncomeExpense = new List<string>();
            List<DateTime> myFakePostTime = new List<DateTime>();
            List<int> myFakeAmount = new List<int>();
            Random random = new Random();

            for(int i=1; i<=100; i++)
            {
                if (random.Next(2) == 1)
                {
                    myFakeIncomeExpense.Add("收入");
                }
                else
                {
                    myFakeIncomeExpense.Add("支出");
                }

                myFakePostTime.Add(DateTime.Now.AddDays(i-100));
                myFakeAmount.Add(random.Next(10000));
            }

            MoenyRecordViewModel viewModel = new MoenyRecordViewModel();
            viewModel.IncomeExpense = myFakeIncomeExpense;
            viewModel.PostTime = myFakePostTime;
            viewModel.Amount = myFakeAmount; 

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}