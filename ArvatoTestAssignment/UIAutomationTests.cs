using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace ArvatoTestAssignment
{
    [TestFixture]
    public class UIAutomationTests
    {
        static IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Invoke()
        {
            driver.Navigate().GoToUrl("http://arvato.ee/en/frontpage/");
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Arvato Services Estonia", driver.Title);
        }
        [Test]
        public void UIAutomationTest1()
        {
            PageObjects PageObjects = new PageObjects();
            PageFactory.InitElements(driver, PageObjects);

            PageObjects.ITDevelopmentCentreBtn.Click();
            Thread.Sleep(1000);
            PageObjects.OpenPositionsBtn.Click();
            Thread.Sleep(1000);
            PageObjects.QAEngineerPosBtn.Click();
            if (PageObjects.WorkAtArvatoText.Displayed)
            {
                Console.WriteLine(PageObjects.WorkAtArvatoText.Text.ToString());
            }
            else
            {
                Assert.Fail();
            }


        }
        [Test]
        public void UIAutomationTest2()
        {
            //Future UIAutomationTest2
        }
        [Test]
        public void UIAutomationTest3()
        {
            //Future UIAutomationTest3
        }
        [TearDown]
        public void Dismiss()
        {
            driver.Quit();
        }
    }
}
