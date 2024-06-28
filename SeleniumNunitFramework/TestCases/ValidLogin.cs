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
    public class ValidLogin : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void SuccessfulLoginWithValidCredentials(string email, string password)
        {
            LoginPage LandingPage = new LoginPage();
            LandingPage.Login(email, password);
            Thread.Sleep(10000);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validUser"), getDataReader().GetTestData("validPassword"));


        }

    }

}
