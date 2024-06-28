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
    public class LoginPage : BaseSetup
    {
        By Username = By.XPath("/html/body/div[1]/div/section/section/div[1]/div[1]/input");
        By Password = By.XPath("/html/body/div[1]/div/section/section/div[1]/div[2]/input");
        By SubmitButton = By.XPath("/html/body/div[1]/div/section/section/div[1]/button");
        By LogOut = By.XPath("/html/body/div[1]/div/section/div/div/article/div[2]/div/div/div/a");
       

        public void Login(string email, string pass)
        {
            //driver.FindElement(Email).SendKeys("omoniyi@gmail.com");
            BrowserActions.Type(Username, email);
            //driver.FindElement(Password).SendKeys("123456789");
            BrowserActions.Type(Password, pass);
            //driver.FindElement(LoginButton).Click();            
            BrowserActions.Click(SubmitButton);
            BrowserActions.Click(LogOut);

        }




    }
}