using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
namespace XYZ_Bank
{
    public class MenuPage : BasePage
    {
        public MenuPage(IWebDriver webDriver) : base(webDriver) { }

        private SelectElement customerSelect => new SelectElement(driver.FindElement(By.Id("userSelect")));
        public void ClickOnCustomerSelect() => customerSelect.SelectByIndex(1);

        private IWebElement btnLogin => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/form/button"));
        public void ClickLogin() => btnLogin.Click();

        private SelectElement accountNumberSelect => new SelectElement(driver.FindElement(By.Id("accountSelect")));
        public void ClickOnAccountNumberSelect() => accountNumberSelect.SelectByIndex(0);

        private IWebElement btnDeposit => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/button[2]"));
        public void ClickDeposit() => btnDeposit.Click();

    }

}