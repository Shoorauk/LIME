using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIME.ApplicationLayer.Pages
{
   public  class TechnicalPage : BasePage
    {
        public IWebDriver _driver;
        public TechnicalPage(IWebDriver driver):base(driver)
        {
            _driver = driver;
        }

        By clickOnTechnicalOption = By.XPath("//span[normalize-space()='Technical']");
        By clickOnSalePartsLink = By.XPath("//div[contains(text(),'Sales Parts')]");        
        By clickOnPartNumber = By.XPath("//a[normalize-space()='0001-000001-001']");
        By validateSalesTitle = By.XPath("//h2[normalize-space()='Sales Part']123");
        By validatePartnumberDesc = By.XPath("//a[normalize-space()='0001-000001-001 Rev 1 : Description text']");

        
        public void ClickOnTechnical()
        {
            ClickOnButton(clickOnTechnicalOption);
        }

        public void ClickOnSalesPart()
        {
            ClickOnButton(clickOnSalePartsLink);
        }

        public void ClickOnPartNumber()
        {
            ClickOnButton(clickOnPartNumber);
           
        }

        public void ValidateSalesTitle(string salestitle)
        {
            Assert.AreEqual(getText(validateSalesTitle), salestitle);
        }

        public void ValidatePartNumberDescribtion(string description)
        {
            Assert.AreEqual(getText(validatePartnumberDesc), description);
        }
    }
}
