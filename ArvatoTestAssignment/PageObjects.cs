using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ArvatoTestAssignment
{
    class PageObjects
    {
        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement ITDevelopmentCentreBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/a/button")]
        public IWebElement OpenPositionsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[4]/div[1]/div[2]/div[1]/h3[2]")]
        public IWebElement WorkAtArvatoText { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[4]/div[2]/div[1]/h4")]
        public IWebElement WeOfferYouText { get; set; }

    }
}
