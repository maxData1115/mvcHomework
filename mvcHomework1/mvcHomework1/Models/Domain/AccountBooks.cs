using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcHomework1.Models.Domain
{
    public class AccountBooks
    {
        public Guid Id { get; set; }
        public int Categoryyy { get; set; }
        public int Amounttt { get; set; }
        public DateTime Dateee { get; set; }
        public string Remarkkk { get; set; }
    }
}