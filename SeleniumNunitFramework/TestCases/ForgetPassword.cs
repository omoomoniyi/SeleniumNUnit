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
    
    public class ForgetPassword : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifyForgetPassword(string email, string password)
        {
            ForgetPasswordPage LandingPage = new ForgetPasswordPage();
            LandingPage.ClickForgetPassword(email);
            Thread.Sleep(10000);

        }


        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validForgetPasswordEmail"), getDataReader().GetTestData("validPassword"));

            //yield return new TestCaseData(getDataReader().GetTestData("noEmail"), getDataReader().GetTestData("validPassword"));

        }


    }
}
