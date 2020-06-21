using HomeworkPOM.Google_search_Task_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace HomeworkPOM.Google_search
{
    [TestFixture]
    public class testQA : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("https://softuni.bg/");
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void findQACourse()
        {
            SoftUniPage softUniPage = new SoftUniPage(Driver);
            softUniPage.coursesTab.Click();
            softUniPage.qaCourse.Click();
            var expectedHeadline = "QA Automation - май 2020";
            var actualHeadline = softUniPage.courseHeadline.Text;
            Assert.AreEqual(expectedHeadline, actualHeadline);

        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
