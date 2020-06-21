using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HomeworkPOM.Google_search_Task_1.Pages
{
    public class googlePage
    {
        private IWebDriver _driver;

        public googlePage(IWebDriver driver)
        {
            _driver = driver;

            PageFactory.InitElements(driver, this);
        }
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }
        [FindsBy(How=How.Name, Using ="q")]
        public IWebElement searchField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#rso > div:nth-child(1) > div > div.r > a > div > cite")]
        public IWebElement searchFirstResult { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/h1[1]")]
        public IWebElement resultHeadline { get; set; }
    }
}
