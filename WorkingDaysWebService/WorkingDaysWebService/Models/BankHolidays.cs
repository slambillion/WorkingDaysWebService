using System;
using System.Collections.Generic;
using System.Data.EntityModel;
using System.Linq;
using System.Web;

namespace WorkingDaysWebService.Models
{
    public class BankHolidays
    {
        public int GetBankHolidays(int month, int year)
        {
            List<DateTime> bankHolidays = new List<DateTime>()
            {
                new DateTime(2012, 1, 2),
                new DateTime(2012, 4, 6),
                new DateTime(2012, 4, 9),
                new DateTime(2012, 5, 7),
                new DateTime(2012, 6, 4),
                new DateTime(2012, 6, 5),
                new DateTime(2012, 8, 27),
                new DateTime(2012, 12, 25),
                new DateTime(2012, 12, 26),
                new DateTime(2013, 1, 1),
                new DateTime(2013, 3, 29),
                new DateTime(2013, 4, 1),
                new DateTime(2013, 5, 6),
                new DateTime(2013, 5, 27),
                new DateTime(2013, 8, 26),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 26),
                new DateTime(2014, 1, 1),
                new DateTime(2014, 4, 18),
                new DateTime(2014, 4, 21),
                new DateTime(2014, 5, 5),
                new DateTime(2014, 5, 26),
                new DateTime(2014, 8, 25),
                new DateTime(2014, 12, 25),
                new DateTime(2014, 12, 26),
                new DateTime(2015, 1, 1),
                new DateTime(2015, 4, 3),
                new DateTime(2015, 4, 6),
                new DateTime(2015, 5, 4),
                new DateTime(2015, 5, 25),
                new DateTime(2015, 8, 31),
                new DateTime(2015, 12, 25),
                new DateTime(2015, 12, 28)
            };

            return bankHolidays.Where(d => d.Year == year && d.Month == month).Count();
            
            // create database context
            // ...
        }
    }
}