using System;

namespace WorkingDaysWebService.Models
{
    public class WorkingDaysService
    {
        public int GetWorkingDays(int month, int year)
        {
            int workingDays = 0;

            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                DateTime today = new DateTime(year, month, i);
                if (!(today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday))
                {
                    workingDays++;
                }
            }

            BankHolidays bh = new BankHolidays();

            return workingDays - bh.GetBankHolidays(month, year);
        }
    }
}