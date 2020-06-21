using HomeworkPOM.Google_search_Task_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace HomeworkPOM.Google_search
{
    [TestFixture]
    public class TestGoogle : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void searchSelenium()
        {
            googlePage googlePage = new googlePage(Driver);
            googlePage.searchField.SendKeys("selenium");
            googlePage.searchField.SendKeys(Keys.Enter);
            googlePage.searchFirstResult.Click();
            var expectedResult = "Selenium automates browsers. That's it!";
            var actualResult = googlePage.resultHeadline.Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
      
    }
}
