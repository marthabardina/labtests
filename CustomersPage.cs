using OpenQA.Selenium;

namespace XYZ_Bank
{
    public class CustomersPage : BasePage
    {
        public CustomersPage(IWebDriver webDriver) : base(webDriver){}

        public string value = "4179";
        private IWebElement enterAmount => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[4]/div/form/div/input"));
        public void EnterAmount() => enterAmount.SendKeys(value);
        private IWebElement btnOnDeposit => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[4]/div/form/button"));
        public void ClickOnDeposit() => btnOnDeposit.Click();
        private string balanceValue => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/strong[2]")).Text;
        public string GetBalanceValue() => balanceValue;
    }
}
