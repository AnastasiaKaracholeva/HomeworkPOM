using HomeworkPOM.Automation_practice_Task_3.Pages;
using HomeworkPOM.Google_search_Task_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace HomeworkPOM.Google_search
{
    [TestFixture]
    public class testAutoPractice : BaseTest3
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void signUpWithValidEmail()
        {
            
            AutomationPracticePage automationPracticePage = new AutomationPracticePage(Driver);
            automationPracticePage.btnSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            automationPracticePage.emailAddressField.SendKeys("test123456789@mailinator.com");
            automationPracticePage.btnCreateAccount.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            

            var expectedEmail = "test123456789@mailinator.com";
            var actualEmail = automationPracticePage.AddressField.GetAttribute("value");
           
            Assert.AreEqual(expectedEmail, actualEmail);



         
        }
        [TearDown]
        public void TearDown()
        {
          Driver.Quit();
        }

    }
}