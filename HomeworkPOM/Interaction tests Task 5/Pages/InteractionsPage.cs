using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HomeworkPOM.Interaction_tests_Task_5.Pages
{
    public class InteractionsPage
    {
        private IWebDriver _driver;

        public InteractionsPage(IWebDriver driver)
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

        // draggable elements 
       

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div")]
        public IWebElement draggableBox { get; set; }

        // droppable elements

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")]
        public IWebElement droppableSourceBox { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[2]")]
        public IWebElement droppableDestinationBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[2]/p")]
        public IWebElement messageAfter { get; set; }

        

        // resizable elements

        [FindsBy(How = How.Id, Using = "resizableBoxWithRestriction")]
        public IWebElement resizableBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div/span")]
        public IWebElement resizableHandle { get; set; }


        // selectable elements


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]")]
        public IWebElement firstSelectableItem { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[3]")]
        public IWebElement selectableItem { get; set; }

        // sortable elements 

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")]
        public IWebElement firstSortableItem { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]")]
        public IWebElement thirdItemDestination { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/div/div[1]")]
        public IWebElement newFirstElement { get; set; }
    }
}



