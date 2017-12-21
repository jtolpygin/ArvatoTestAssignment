using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ArvatoTestAssignment
{
    class PageObjects
    {
        //List of WebElements.
        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement ITDevelopmentCentreBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a > button")]
        public IWebElement OpenPositionsBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.open-positions-content")]
        public IWebElement WorkAtArvatoText { get; set; }

        [FindsBy(How = How.LinkText, Using = "QA Engineer")]
        public IWebElement QAEngineerPosBtn { get; set; }

    }
}
