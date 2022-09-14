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
    public class SFALogin : BaseSetup
    {
        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void VerifySFALoginWithInvalidEmail(string email, string password)
        {
            SFALandingPage LandingPage = new SFALandingPage();
            LandingPage.Login(email, password);
            Thread.Sleep(10000);

        }


        public static IEnumerable<TestCaseData> GetTestData()
        {
                yield return new TestCaseData(getDataReader().GetTestData("validEmail"), getDataReader().GetTestData("validPassword"));
            
                yield return new TestCaseData(getDataReader().GetTestData("noEmail"), getDataReader().GetTestData("validPassword"));

                

        }



        //[Test]
        //[TestCaseSource(nameof(GetTestData))]
        //public void VerifyClickForgetPassword(string email, string password)
        //{
        //    SFALandingPage LandingPage = new SFALandingPage();
        //    LandingPage.ClickForgetPassword(email);
        //    Thread.Sleep(10000);
            
            

        //}



        //[Test]
        //[TestCaseSource(nameof(GetTestData))]
        //public void VerifySFALoginWithInvalidPassword(string email, string password)
        //{
        //    SFALandingPage LandingPage = new SFALandingPage();
        //    LandingPage.Login(email, password);
        //    Thread.Sleep(10000);


        //    //driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]")).SendKeys("titus.salisu@omnibiz.com");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]")).SendKeys("xyz12345678xyz");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();
        //    //Thread.Sleep(5000);

        //}


        //[Test]
        //public void VerifySFALoginWithoutEmail()
        //{

        //    SFALandingPage LandingPage = new SFALandingPage();
        //    LandingPage.Login("", "q1234567789");
        //    Thread.Sleep(10000);


        //    //driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]")).SendKeys("");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]")).SendKeys("12345678");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();
        //    //Thread.Sleep(5000);

        //}

        //[Test]
        //public void VerifySFALoginWithoutPassword()
        //{
        //    SFALandingPage LandingPage = new SFALandingPage();
        //    LandingPage.Login("omoniyi@gmail", "");
        //    Thread.Sleep(10000);


        //    driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]")).SendKeys("abc@gmail.com");
        //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]")).SendKeys("");
        //    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();
        //    Thread.Sleep(5000);

        //}

        //[Test]
        //public void VerifySFALoginWithValidCredentials()
        //{

        //    SFALandingPage LandingPage = new SFALandingPage();
        //    LandingPage.Login("titus.salisu@omnibiz.com", "SD12345678");
        //    Thread.Sleep(10000);



        //    //driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]")).SendKeys("titus.salisu@omnibiz.com");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]")).SendKeys("adf12345678");
        //    //driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();
        //    //Thread.Sleep(20000);

        //}

    }

}
