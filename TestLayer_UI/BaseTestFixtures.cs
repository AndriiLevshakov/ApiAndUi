using Core_UI.Logger;
using Core_UI.WebDriver;
using OpenQA.Selenium.Support.UI;
using static Core_UI.WebDriver.CustomWaiter;
using static Core_UI.WebDriver.WebDriverManager;

namespace TestLeyer_UI
{
    public abstract class BaseTestFixtures
    {
        public bool _headlessMode;
        protected WebDriverManager _webDriverManager;

        protected BaseTestFixtures()
        {
            _webDriverManager = new WebDriverManager();
        }

        [SetUp]
        public void SetUp()
        {
            _wait = new WebDriverWait(CurrentDriver, TimeSpan.FromSeconds(5));

            LoggerManager.Logger.Info($"Starting {TestContext.CurrentContext.Test.MethodName}");
        }

        [TearDown]
        public void TearDown()
        {
            string? testName = TestContext.CurrentContext.Test.MethodName;

            ScreenShot.CaptureScreenshot(WebDriverManager.CurrentDriver, testName + ".png");

            QuitDriver();
        }
    }
}

