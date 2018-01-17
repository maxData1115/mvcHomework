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
            List<MoneyRecordViewModel> fakeList = new List<MoneyRecordViewModel>();

            Random random = new Random();
            for(int i = 0; i <= 99; i++)
            {
                MoneyRecordViewModel fakeData= new MoneyRecordViewModel();
                fakeData.IncomeExpense= (random.Next() %2==0) ? "收入" : "支出";
                fakeData.PostTime = DateTime.Now.AddDays(i - 99);
                fakeData.Amount = random.Next(1000000);

                fakeList.Add(fakeData);
            }
            return View(fakeList);
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