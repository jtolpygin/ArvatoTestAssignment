using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace ArvatoTestAssignment
{
    [TestFixture]
    public class UIAutomationTests
    {
        //Create references for Google Chrome browser.
        static IWebDriver driver = new ChromeDriver();
        static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        [SetUp]
        public void Invoke()
        {
            //Setting up base url.
            driver.Navigate().GoToUrl("http://arvato.ee/en/frontpage/");
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Arvato Services Estonia", driver.Title);
            
        }
        [Test]
        public void UIAutomationTest1()
        {
            //Initialize page elements.
            PageObjects PageObjects = new PageObjects();
            PageFactory.InitElements(driver, PageObjects);

            //Testcase steps
            wait.Until(ExpectedConditions.ElementToBeClickable(PageObjects.ITDevelopmentCentreBtn));
            PageObjects.ITDevelopmentCentreBtn.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(PageObjects.OpenPositionsBtn));
            PageObjects.OpenPositionsBtn.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(PageObjects.QAEngineerPosBtn));
            PageObjects.QAEngineerPosBtn.Click();

            //Verification (Output)
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
