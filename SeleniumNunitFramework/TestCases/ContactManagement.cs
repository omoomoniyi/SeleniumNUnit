using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestCases
{
    public class ContactManagement :BaseSetup
    {


        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifySFALoginWithValidCredential(string email, string password)
        {
            UserDashboard LandingPage = new UserDashboard();
            LandingPage.Login(email, password);
            Thread.Sleep(15000);




        //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/a[1]/div[1]/span[2]/img[1]")).Click();
        //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/div[1]/a[1]")).Click();
        //    driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[1]/div[8]")).Click();
        //    driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]"));
        //    Thread.Sleep(10000);

        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifyBusinessSwitch(string email, string password)
        {
            UserDashboard LandingPage = new UserDashboard();
            LandingPage.Login(email, password);
            Thread.Sleep(15000);




            //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/a[1]/div[1]/span[2]/img[1]")).Click();
            //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/div[1]/a[1]")).Click();
            //    driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[1]/div[8]")).Click();
            //    driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]"));
            //    Thread.Sleep(10000);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("validEmail"), getDataReader().GetTestData("validPassword"));

            //yield return new TestCaseData(getDataReader().GetTestData("noEmail"), getDataReader().GetTestData("validPassword"));



        }



    }
}
