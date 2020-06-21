using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkPOM.Automation_practice_Task_3.Pages
{
    public class AutomationPracticePage
    {
        private IWebDriver _driver;

        public AutomationPracticePage(IWebDriver driver)
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
        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div.header_user_info > a")]
        public IWebElement btnSignIn { get; set; }


        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement emailAddressField { get; set; }



        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span")]
        public IWebElement btnCreateAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input")]
        public IWebElement AddressField { get; set; }
       
    }

}


