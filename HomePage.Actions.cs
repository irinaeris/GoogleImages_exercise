using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema_28._10.PageObjects
{
    partial class HomePage
    {
        public void GoToAgreeButton()
        {
            agreeButton.Click();
        }

        public void SearchImage(string query)
        {
            searchTextBox.SendKeys(query);
            searchTextBox.SendKeys(Keys.Enter);
        }

        public void SelectImage()
        {
            imagesButton.Click();
            firstImageFound.Click();
        }
    }
}
