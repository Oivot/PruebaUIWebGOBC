using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace PruebaUIWebGOBC
{
    [TestClass]
    public class GoogleSearchTest
    {
        private IWebDriver driver;

        public GoogleSearchTest()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]

        public void SearchInGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            var searchBox = driver.FindElement(By.Name("q"));

            searchBox.SendKeys("OpenAi");

            searchBox.Submit();

            System.Threading.Thread.Sleep(2000);

            Assert.IsTrue(driver.Title.Contains("OpenAi"), "El titulo no contiene 'OpenAi'");
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
