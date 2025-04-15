using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SampleProject
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://usdigital.bmo.com/www/#/login");
            driver.Manage().Window.Maximize();          
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}