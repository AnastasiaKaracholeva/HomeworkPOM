using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HomeworkPOM.AP_Registration_negative_tests_Task_4
{
    public class AutomationpracticeRegistrationPage 
    {
        private IWebDriver _driver;

        public AutomationpracticeRegistrationPage(IWebDriver driver)
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

        
        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement buttonSignIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#email_create")]
        public IWebElement emailEmptyField { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span")]
        public IWebElement buttonCreate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-creation_form > div:nth-child(1) > h3")]
        public IWebElement subheading { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submitAccount > span")]
        public IWebElement buttonRegister { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div")]
        public IWebElement errorBlock { get; set; }

        

        [FindsBy(How = How.CssSelector, Using = "#customer_firstname")]
        public IWebElement firstNameField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#customer_lastname")] 
        public IWebElement lastNameField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        public IWebElement passwordField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#address1")]
        public IWebElement addressField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#city")]
        public IWebElement cityField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_state")]
        public IWebElement stateField { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#postcode")]
        public IWebElement postalCodeField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_country")]
        public IWebElement countryField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#phone_mobile")]
        public IWebElement phoneField { get; set; }

      

    }
}
