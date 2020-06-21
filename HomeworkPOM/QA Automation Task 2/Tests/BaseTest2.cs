using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace HomeworkPOM
{
    [TestFixture]
    public class BaseTest2
    {
        protected IWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        protected WebDriverWait Wait { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
        }
    }
}
