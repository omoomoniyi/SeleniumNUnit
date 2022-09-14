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
    public class UserDashboard : BaseSetup
    {
        By Email = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By EyeIcon = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/span[2]/*[1]");
        By ContactManagementMenu = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[2]/a[1]/div[1]/span[2]/img[1]");
        By ContactsSubMenu = By.XPath("//a[contains(text(),'Contacts')]");
        By EllipseIcon = By.XPath("//body/div[@id='app-root']/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[1]/div[8]");
        By ReAssignButton = By.XPath("//body/div[@id='app-root']/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[2]");
        By AssignContactToDropDownButton = By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[4]/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/div[2]/div[1]/div[2]/div[1]/svg[1]/path[1]");
        By SwitchBusinessesDropDown = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/img[1]");
        By ClickIndomieBusinessInDropDown = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/select[1]");
        By SelectIndomieNoodlesSales = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/select[1]/option[27]");
        By CloseBusinessSwitchModalConfirmation = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/button[1]");


        public void Login(string email, string pass)
        {
            //driver.FindElement(Email).SendKeys("omoniyi@gmail.com");
            BrowserActions.Type(Email, email);
            //driver.FindElement(Password).SendKeys("123456789");
            BrowserActions.Type(Password, pass);
            //driver.FindElement(LoginButton).Click();
            //BrowserActions.Click(EyeIcon);
            BrowserActions.Click(LoginButton);
            Thread.Sleep(5000);
            driver.Navigate().Refresh();
            Thread.Sleep(10000);
            BrowserActions.MouseEvent(SwitchBusinessesDropDown); //Trying to create browserActions to MouseOver on to select BusinessDropDowns
            BrowserActions.Click(ClickIndomieBusinessInDropDown);
            BrowserActions.Click(SelectIndomieNoodlesSales);
            BrowserActions.Click(CloseBusinessSwitchModalConfirmation);
            BrowserActions.Click(ContactManagementMenu);
            BrowserActions.Click(ContactsSubMenu);
            
            

        }
    }

    

    



   



}
