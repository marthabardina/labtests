using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XYZ_Bank
{
    public class CustomerLoginPage : BasePage
    {
        public CustomerLoginPage(IWebDriver webDriver) : base(webDriver) { }

        private IWebElement btnCustomerLogin => driver.FindElement(By.XPath("//button[@ng-click='customer()']"));
        public void ClickCustomerLogin() => btnCustomerLogin.Click();
    }
}
