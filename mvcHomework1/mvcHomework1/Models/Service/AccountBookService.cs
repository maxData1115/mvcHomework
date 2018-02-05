using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHomework1.Enum;
using mvcHomework1.Models.Domain;
using mvcHomework1.Models.Repository;
using mvcHomework1.ViewModels;

namespace mvcHomework1.Service
{
    public class AccountBookService
    {
        AccountBooksRepository accountBooksRepository;

        public AccountBookService()
        {
            this.accountBooksRepository = new AccountBooksRepository();
        }

        public IEnumerable<AccountBooks> GetTopNAccount(int count)
        {
            return accountBooksRepository.GetAccount(count);
        }

        public void AddNewAccount(Guid id,ViewModels.MoneyRecordViewModel data)
        {
            accountBooksRepository.AddAccount(id,(int)data.IncomeExpense,(int)data.Amount,data.PostTime,data.Remark);
        }
    }

 
}