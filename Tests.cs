using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tema_28._10.PageObjects;
using OpenQA.Selenium;

namespace Tema_28._10
{
    [TestFixture]
    class Tests : Hooks 
    {
        [Test]
        public void GoogleImagesSearch()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);

            // Act
            Driver.SwitchTo().Frame(0);
            homePage.GoToAgreeButton();
            System.Threading.Thread.Sleep(2000);
            homePage.SearchImage("paris");
            System.Threading.Thread.Sleep(2000);
            homePage.SelectImage();
            System.Threading.Thread.Sleep(2000);
            Driver.Navigate().Back();

            //Assert
            Assert.IsTrue(homePage.searchTextBox.Displayed);
        }

    }
}

