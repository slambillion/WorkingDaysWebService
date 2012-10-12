using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingDaysWebService.Tests.Models
{
    [TestClass]
    public class BankHolidayTest
    {
        [TestMethod]
        public void GetBankHolidaysInSeptember2012()
        {
            WorkingDaysWebService.Models.BankHolidays bankHolidays = new WorkingDaysWebService.Models.BankHolidays();

            int result = bankHolidays.GetBankHolidays(9, 2012);

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void GetBankHolidaysInAugust2012()
        {
            WorkingDaysWebService.Models.BankHolidays bankHolidays = new WorkingDaysWebService.Models.BankHolidays();

            int result = bankHolidays.GetBankHolidays(8, 2012);

            Assert.IsTrue(result == 1);
        }
    }
}
