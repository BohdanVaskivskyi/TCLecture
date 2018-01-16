using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public class GithubTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void BeforeEach()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Contains_sign_up_page()
        {
            _driver.Url = "https://github.com";

            IWebElement element = _driver.FindElement(By.CssSelector(".home-hero-signup"));

            Assert.IsNotNull(element);
        }

        [TearDown]
        public void AfterEach()
        {
            _driver.Quit();
        }
    }
}
