using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.PageObject
{
    public class SFALandingPage :BaseSetup
    {
        By Email = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By EyeIcon = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/span[2]/*[1]");
        By ForgetPassword = By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div[3]/form/div[4]/span");

        public void Login(string email, string pass)
        {
            //driver.FindElement(Email).SendKeys("omoniyi@gmail.com");
            BrowserActions.Type(Email, email);
            //driver.FindElement(Password).SendKeys("123456789");
            BrowserActions.Type(Password, pass);
            //driver.FindElement(LoginButton).Click();
            BrowserActions.Click(EyeIcon);
            BrowserActions.Click(LoginButton);

        }



    
    }
}
