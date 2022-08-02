using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestCases
{
    public class SFALogin:BaseSetup
    {
        [Test]
        public void VerifySFALoginWithInvalidEmail() 
        {
            driver.FindElement(By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]")).SendKeys("abc@gmail.com");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]")).SendKeys("12345678");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]")).Click();
            Thread.Sleep(5000);
        }

        [Test]
        public void VerifySFALoginWithInvalidPassword()
        {

        }

        [Test]
        public void VerifySFALoginWithoutEmail()
        {

        }

        [Test]
        public void VerifySFALoginWithoutPassword()
        {

        }

        [Test]
        public void VerifySFALoginWithValidCredentials()
        {

        }

    }

}
