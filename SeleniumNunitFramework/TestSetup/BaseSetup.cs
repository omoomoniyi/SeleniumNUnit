using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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

        public static IWebDriver driver;

        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void TestSuiteSetup()
        {

            string workingDirectory = Environment.CurrentDirectory; //Get path of Base.Setup.cs
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string reportPath = projectDirectory + "/index.hmtl";

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local Host");
            extent.AddSystemInfo("Environment", "LIVE");
            extent.AddSystemInfo("Country", "Nigeria");
            extent.AddSystemInfo("UserName", "OmoniyiQA");


        }


        [SetUp] 
        public void Setup()
        {
            //string browserName = 
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            string browser = ConfigurationManager.AppSettings["browser"];
            this.InitBrowser(browser);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DEFAULT_TIMEOUT);
            driver.Url = ConfigurationManager.AppSettings["liveURL"];
        }


        [TearDown]

        public void TearDown()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if(status == TestStatus.Failed)
            {
                test.Fail("Test Case Failed");

            }

            else if(status == TestStatus.Passed)
            {
                test.Pass("Test Case Passed");
            }
            extent.Flush();

            if(driver != null)
            {

                driver.Quit();
            }

        }

        public static JsonReader getDataReader()
        {

            return new JsonReader();
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
