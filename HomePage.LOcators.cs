using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tema_28._10.PageObjects
{
    partial class HomePage
    {
        public IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement imageFrame => _driver.FindElement(By.XPath("//*[@id='Sva75c']"));
        private IWebElement agreeButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']/span/span"));
        public IWebElement searchTextBox => _driver.FindElement(By.XPath("//input[@name='q']"));
        private IWebElement imagesButton => _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
        private IWebElement firstImageFound => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));
       
    }
}
