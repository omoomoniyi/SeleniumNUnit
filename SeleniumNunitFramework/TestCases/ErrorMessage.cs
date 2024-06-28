using NUnit.Framework;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestCases
{
    public class ErrorMessage : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void ErrorMessageDisplayWhenLoginFails(string email, string password)

        {
            ErrorMessagePage LandingPage = new ErrorMessagePage();
            LandingPage.Login(email, password);
            Thread.Sleep(10000);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("invalidUser"), getDataReader().GetTestData("invalidPassword"));


        }

    }

}
