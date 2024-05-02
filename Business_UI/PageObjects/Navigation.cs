using static Core_UI.WebDriver.WebDriverManager;

namespace Business_UI.PageObjects
{
    public class Navigation
    {
        public void NavigateToStartPage()
        {
            CurrentDriver.Navigate().GoToUrl(BaseUrl);
        }
    }
}
