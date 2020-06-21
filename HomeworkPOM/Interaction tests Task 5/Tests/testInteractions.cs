using HomeworkPOM.Interaction_tests_Task_5;
using HomeworkPOM.Interaction_tests_Task_5.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace HomeworkPOM.Interaction_tests_Task_5
{
    [TestFixture]
    public class testInteractions : BaseTest5
    {
        [SetUp]
        public void SetUp()
        {
            Initialize();
          
            Driver.Manage().Window.Maximize();
        }

        //draggable tests 
        [Test]
        public void DraggableItemIsMovedAndPositionXIsDifferent()
        {
           
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            var draggableBoxX = interactionsPage.draggableBox.Location.X;

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Builder.DragAndDropToOffset(interactionsPage.draggableBox, 200, 100).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var draggableBoxXpositionAfter = interactionsPage.draggableBox.Location.X;
            Assert.AreNotEqual(draggableBoxX, draggableBoxXpositionAfter);

        }

        [Test]
        public void DraggableItemIsMovedAndPositionYIsDifferent()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            var draggableBoxX = interactionsPage.draggableBox.Location.Y;

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Builder.DragAndDropToOffset(interactionsPage.draggableBox, 200, 100).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var draggableBoxYpositionAfter = interactionsPage.draggableBox.Location.Y;
            Assert.AreNotEqual(draggableBoxX, draggableBoxYpositionAfter);


        }

        [Test]
        public void DraggableItemIsNotMoved()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/dragabble");
            var draggableBoxX = interactionsPage.draggableBox.Location.Y;

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Builder.DragAndDropToOffset(interactionsPage.draggableBox, 0, 0).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            var draggableBoxYpositionAfter = interactionsPage.draggableBox.Location.Y;
            Assert.AreEqual(draggableBoxX, draggableBoxYpositionAfter);


        }

        //droppable tests
        [Test]
        public void DragAndDropCheckColor()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");

            var colourBefore = interactionsPage.droppableDestinationBox.GetCssValue("background-color");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Builder.DragAndDrop(interactionsPage.droppableSourceBox, interactionsPage.droppableDestinationBox).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
           


            var colorAfter = interactionsPage.droppableDestinationBox.GetCssValue("color");

            Assert.AreNotEqual(colourBefore, colorAfter);


        }
        [Test]
        public void DragAndDropCheckMessageAfterDrop()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");

   

            Builder.DragAndDrop(interactionsPage.droppableSourceBox, interactionsPage.droppableDestinationBox).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var actualMessage = interactionsPage.messageAfter.Text;

            Assert.IsTrue(actualMessage.Contains("Dropped!"));



        }

        [Test]
        public void DragAndDropCheckMessageIsChanged()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/droppable");



            Builder.DragAndDrop(interactionsPage.droppableSourceBox, interactionsPage.droppableDestinationBox).Perform();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var actualMessage = interactionsPage.messageAfter.Text;

            Assert.IsFalse(actualMessage.Contains("Drop here"));

        }

        // resizable tests

        [Test]
        public void MakeSureItemIsResizedByWidth()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");

            var boxSize = interactionsPage.resizableBox.GetCssValue("width");

            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            Builder.ClickAndHold(interactionsPage.resizableHandle);
            Builder.DragAndDropToOffset(interactionsPage.resizableHandle, 100, 50);
            Builder.Release().Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var boxSizeAfter = interactionsPage.resizableBox.GetCssValue("width");

            Assert.AreNotEqual(boxSize, boxSizeAfter);

        }

        [Test]
        public void MakeSureItemIsResizedByHeight()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/resizable");

            var boxSize = interactionsPage.resizableBox.GetCssValue("height");


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            Builder.ClickAndHold(interactionsPage.resizableHandle);
            Builder.DragAndDropToOffset(interactionsPage.resizableHandle, 100, 150);
            Builder.Release().Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var boxSizeAfter = interactionsPage.resizableBox.GetCssValue("height");

            Assert.AreNotEqual(boxSize, boxSizeAfter);

        }

        // selectable tests

        [Test]
        public void CheckIfItemIsSelectable()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");

            var firstItemColor = interactionsPage.selectableItem.GetCssValue("color");
            interactionsPage.selectableItem.Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);


            var firstItemColorAfter = interactionsPage.selectableItem.GetCssValue("color");


            Assert.AreNotEqual(firstItemColor, firstItemColorAfter);

        }
        [Test]
        public void CheckIfItemIsSameColorAfterBeingSelectedTwice()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/selectable");

            var firstItemColor = interactionsPage.selectableItem.GetCssValue("color");

            Builder.DoubleClick(interactionsPage.selectableItem);
            

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);


            var firstItemColorAfter = interactionsPage.selectableItem.GetCssValue("color");


            Assert.AreEqual(firstItemColor, firstItemColorAfter);

        }

        // sortable tests

        [Test]
        public void CheckIfItemsCanBeSorted()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");

            var firstItemText = interactionsPage.firstSortableItem.Text;



            Builder.DragAndDrop(interactionsPage.firstSortableItem, interactionsPage.thirdItemDestination).Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var newFirstItemText = interactionsPage.newFirstElement.Text;


            Assert.AreNotEqual(firstItemText, newFirstItemText);

        }
        [Test]
        public void CheckIfItemsCanBeSortedProperly()
        {
            InteractionsPage interactionsPage = new InteractionsPage(Driver);
            Driver.Navigate().GoToUrl("http://demoqa.com/sortable");

            Builder.DragAndDrop(interactionsPage.firstSortableItem, interactionsPage.thirdItemDestination).Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            var newFirstItemText = interactionsPage.newFirstElement.Text;


            Assert.IsTrue(newFirstItemText.Contains("Two"));

        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
