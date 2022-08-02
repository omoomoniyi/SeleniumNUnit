using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNunitFramework.TestSetup
{
    public class BaseSetup
    {

        public IWebDriver driver;


        [SetUp] 
        public void Setup()
        {
            //string browserName = 
            string browser = ConfigurationManager.AppSettings["browser"];
            this.InitBrowser(browser);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT);
            driver.Url = ConfigurationManager.AppSettings["liveURL"];
        }


        [TearDown]

        public void TearDown()
        {
            if(driver != null)
            {

                driver.Quit();
            }

        }

        public void InitBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.LeaveBrowserRunning = true;
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver(options);
                    driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "safari":


                    driver = new SafariDriver();
                    driver.Manage().Window.Maximize();
                    break;
                    default:
                        ChromeOptions options1 = new ChromeOptions();
                        options1.LeaveBrowserRunning = true;
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver(options1);
                        driver.Manage().Window.Maximize();
                        break;
                    

            }
        }
    }
}
