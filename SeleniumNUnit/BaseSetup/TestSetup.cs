using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnit.BaseSetup
{
    public class TestSetup 
    
    { 
        public  IWebDriver driver;

        [SetUp]
        public void SetUp()

        {

            ChromeOptions options = new ChromeOptions();
            options.LeaveBrowserRunning = true;
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(options);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //Navigate to Wikipedia

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TearDown]
        public void TearDown()
        {

            driver.Quit();

        }
    }
}
