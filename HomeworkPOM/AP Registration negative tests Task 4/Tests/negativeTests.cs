using HomeworkPOM.AP_Registration_negative_tests_Task_4;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace HomeworkPOM.AP_Registration_negative_tests_Task_4
{
    [TestFixture]
    public class Test : BaseTest4
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Window.Maximize();
        }
        [Test]
        public void userCanNotRegisterWithEmptyFields()
        {
            

            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.subheading.Click();
            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            Assert.IsTrue(automationpractice.errorBlock.Displayed);

        }

        [Test]
        public void userCanNotRegisterWithEmptyFirstName()
        {


            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            Builder.MoveToElement(automationpractice.lastNameField).Perform();
            automationpractice.lastNameField.SendKeys("anyLastName");

            Builder.MoveToElement(automationpractice.passwordField).Perform();
            automationpractice.passwordField.SendKeys("password");

            Builder.MoveToElement(automationpractice.addressField).Perform();
            automationpractice.passwordField.SendKeys("address1");

            Builder.MoveToElement(automationpractice.cityField).Perform();
            automationpractice.cityField.SendKeys("someCity");


            Builder.MoveToElement(automationpractice.stateField).Perform();
            automationpractice.stateField.SendKeys("Alabama");


            Builder.MoveToElement(automationpractice.postalCodeField).Perform();
            automationpractice.postalCodeField.SendKeys("45634653");

            Builder.MoveToElement(automationpractice.countryField).Perform();
            automationpractice.countryField.SendKeys("USA");

            Builder.MoveToElement(automationpractice.phoneField).Perform();
            automationpractice.phoneField.SendKeys("777235923");

            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var errorMessage = automationpractice.errorBlock.Text;

            

            Assert.IsTrue(errorMessage.Contains("firstname"));

        }

        [Test]
        public void userCanNotRegisterWithEmptyLastName()
        {


            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            Builder.MoveToElement(automationpractice.firstNameField).Perform();
            automationpractice.firstNameField.SendKeys("anyFirstName");

            Builder.MoveToElement(automationpractice.passwordField).Perform();
            automationpractice.passwordField.SendKeys("password");

            Builder.MoveToElement(automationpractice.addressField).Perform();
            automationpractice.passwordField.SendKeys("address1");

            Builder.MoveToElement(automationpractice.cityField).Perform();
            automationpractice.cityField.SendKeys("someCity");


            Builder.MoveToElement(automationpractice.stateField).Perform();
            automationpractice.stateField.SendKeys("Alabama");


            Builder.MoveToElement(automationpractice.postalCodeField).Perform();
            automationpractice.postalCodeField.SendKeys("45634653");

            Builder.MoveToElement(automationpractice.countryField).Perform();
            automationpractice.countryField.SendKeys("USA");

            Builder.MoveToElement(automationpractice.phoneField).Perform();
            automationpractice.phoneField.SendKeys("777235923");

            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var errorMessage = automationpractice.errorBlock.Text;



            Assert.IsTrue(errorMessage.Contains("lastname"));

        }


        [Test]
        public void userCanNotRegisterWhenPasswordIsUnderFiveCharacters()
        {


            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            Builder.MoveToElement(automationpractice.firstNameField).Perform();
            automationpractice.firstNameField.SendKeys("anyFirstName");

            Builder.MoveToElement(automationpractice.lastNameField).Perform();
            automationpractice.lastNameField.SendKeys("anyLastName");

            Builder.MoveToElement(automationpractice.passwordField).Perform();
            automationpractice.passwordField.SendKeys("pas");

            Builder.MoveToElement(automationpractice.addressField).Perform();
            automationpractice.passwordField.SendKeys("");

            Builder.MoveToElement(automationpractice.cityField).Perform();
            automationpractice.cityField.SendKeys("");


            Builder.MoveToElement(automationpractice.stateField).Perform();
            automationpractice.stateField.SendKeys("Alabama");


            Builder.MoveToElement(automationpractice.postalCodeField).Perform();
            automationpractice.postalCodeField.SendKeys("45634653");

            Builder.MoveToElement(automationpractice.countryField).Perform();
            automationpractice.countryField.SendKeys("USA");

            Builder.MoveToElement(automationpractice.phoneField).Perform();
            automationpractice.phoneField.SendKeys("777235923");

            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var errorMessage = automationpractice.errorBlock.Text;



            Assert.IsTrue(errorMessage.Contains("passwd is invalid"));

        }

        [Test]
        public void userCanNotRegisterWhenCityIsEmpty()
        {


            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            Builder.MoveToElement(automationpractice.firstNameField).Perform();
            automationpractice.firstNameField.SendKeys("anyFirstName");

            Builder.MoveToElement(automationpractice.lastNameField).Perform();
            automationpractice.lastNameField.SendKeys("anyLastName");

            Builder.MoveToElement(automationpractice.passwordField).Perform();
            automationpractice.passwordField.SendKeys("password");

            Builder.MoveToElement(automationpractice.addressField).Perform();
            automationpractice.passwordField.SendKeys("address1");

            Builder.MoveToElement(automationpractice.stateField).Perform();
            automationpractice.stateField.SendKeys("Alabama");


            Builder.MoveToElement(automationpractice.postalCodeField).Perform();
            automationpractice.postalCodeField.SendKeys("45634653");

            Builder.MoveToElement(automationpractice.countryField).Perform();
            automationpractice.countryField.SendKeys("USA");

            Builder.MoveToElement(automationpractice.phoneField).Perform();
            automationpractice.phoneField.SendKeys("777235923");

            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var errorMessage = automationpractice.errorBlock.Text;



            Assert.IsTrue(errorMessage.Contains("city is required"));

        }

        [Test]
        public void userCanNotRegisterWhenZIPCodeIsInvalid()
        {


            AutomationpracticeRegistrationPage automationpractice = new AutomationpracticeRegistrationPage(Driver);
            automationpractice.buttonSignIn.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            automationpractice.emailEmptyField.Click();
            automationpractice.emailEmptyField.SendKeys("testhomework3@mailinator.com");
            automationpractice.buttonCreate.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            Builder.MoveToElement(automationpractice.firstNameField).Perform();
            automationpractice.firstNameField.SendKeys("anyFirstName");

            Builder.MoveToElement(automationpractice.lastNameField).Perform();
            automationpractice.lastNameField.SendKeys("anyLastName");

            Builder.MoveToElement(automationpractice.passwordField).Perform();
            automationpractice.passwordField.SendKeys("password");

            Builder.MoveToElement(automationpractice.addressField).Perform();
            automationpractice.passwordField.SendKeys("address1");

            Builder.MoveToElement(automationpractice.cityField).Perform();
            automationpractice.cityField.SendKeys("someCity");


            Builder.MoveToElement(automationpractice.stateField).Perform();
            automationpractice.stateField.SendKeys("Alabama");


            Builder.MoveToElement(automationpractice.postalCodeField).Perform();
            automationpractice.postalCodeField.SendKeys("45634653");

            Builder.MoveToElement(automationpractice.countryField).Perform();
            automationpractice.countryField.SendKeys("USA");

            Builder.MoveToElement(automationpractice.phoneField).Perform();
            automationpractice.phoneField.SendKeys("777235923");

            Builder.MoveToElement(automationpractice.buttonRegister).Perform();
            automationpractice.buttonRegister.Click();


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var errorMessage = automationpractice.errorBlock.Text;



            Assert.IsTrue(errorMessage.Contains("The Zip/Postal code you've entered is invalid"));

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
