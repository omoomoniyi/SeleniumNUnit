using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnit.BaseSetup;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNUnit
{
    public class Tests : TestSetup
    {



        [Test, Order(1), Category("Functional Testing")]
        [Author("Omoniyi")]
        public void Test1()
        {


            driver.Navigate().GoToUrl("https://subdstore.vercel.app/#/store");


        }

            
        /*[Test, Order(2), Category("Sanity Testing")]
        [Author("Silverlining")]
        //[Ignore ("Not including this in execution")]

        public void Test2()
        {


            driver.Navigate().GoToUrl("https://sfa.mplify.ng");



        }

        [Test, Order(5), Repeat(3), Category("Regression Testing")]
        [Author("Olufemi")]
        public void Test3()
        {


            driver.Navigate().GoToUrl("https://jimidisu.com");



        }

        [Test, Order(4), Repeat(3), Category("Smoke Testing")]
        [Author("Michael")]
            public void Test4()
        {


            driver.Navigate().GoToUrl("https://way2automation.com");



        } 

        */


    }

}