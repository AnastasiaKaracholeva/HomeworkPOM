using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HomeworkPOM.Google_search_Task_1.Pages
{
    public class SoftUniPage
    {
        private IWebDriver _driver;

        public SoftUniPage(IWebDriver driver)
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
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span")]
        public IWebElement coursesTab { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul/div[1]/ul/li/a")]
        public IWebElement qaCourse { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div.content > header > h1")]
        public IWebElement courseHeadline { get; set; }
    }
}
