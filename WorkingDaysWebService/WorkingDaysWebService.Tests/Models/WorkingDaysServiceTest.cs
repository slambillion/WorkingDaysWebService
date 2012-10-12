using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingDaysWebService.Tests.Models
{
    [TestClass]
    public class WorkingDaysServiceTest
    {
        [TestMethod]
        public void GetWorkingDaysInSeptember2012()
        {
            WorkingDaysWebService.Models.WorkingDaysService model = new WorkingDaysWebService.Models.WorkingDaysService();

            int result = model.GetWorkingDays(9, 2012);

            Assert.IsTrue(result == 20);
        }

        [TestMethod]
        public void GetWorkingDaysInOctober2012()
        {
            WorkingDaysWebService.Models.WorkingDaysService model = new WorkingDaysWebService.Models.WorkingDaysService();

            int result = model.GetWorkingDays(10, 2012);

            Assert.IsTrue(result == 23);
        }

        [TestMethod]
        public void GetWorkingDaysInAugust2012_BankHoliday()
        {
            WorkingDaysWebService.Models.WorkingDaysService model = new WorkingDaysWebService.Models.WorkingDaysService();

            int result = model.GetWorkingDays(8, 2012);

            Assert.IsTrue(result == 22);
        }
    }
}
