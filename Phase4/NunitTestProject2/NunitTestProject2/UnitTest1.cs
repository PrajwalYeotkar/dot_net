using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace NUnit_Demo_1
{
    class NUnitDemo_1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_duckduckgo()
        {
            driver.Url = "https://www.duckduckgo.com";
            System.Threading.Thread.Sleep(4000);

            IWebElement element = driver.FindElement(By.XPath("//input[@id='search_form_input_homepage']"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}

namespace NUnit_Demo_2
{
    class NUnitDemo_2
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_google()
        {
            driver.Url = "https://www.google.com";
            System.Threading.Thread.Sleep(4000);

            IWebElement element = driver.FindElement(By.XPath("//input[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}