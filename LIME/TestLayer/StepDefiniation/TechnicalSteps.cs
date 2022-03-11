using LIME.ApplicationLayer.Pages;
using LIME.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LIME.TestLayer.StepDefiniation
{
    [Binding]
    public sealed class TechnicalSteps
    {
        private TechnicalPage _technicalPage;

        public TechnicalSteps(WebDriver driver)
        {
            _technicalPage = new TechnicalPage(driver.Driver);
        }

        [When(@"Click on Technocal link from menu")]
        public void WhenClickOnTechnocalLinkFromMenu()
        {
            _technicalPage.ClickOnTechnical();
        }

        [When(@"Sales part icon is clicked")]
        public void WhenSalesPartIconIsClicked()
        {
            _technicalPage.ClickOnSalesPart();
        }

        

        [When(@"Select the partnumber")]
        public void WhenSelectThePartnumber()
        {
            _technicalPage.ClickOnPartNumber();
        }


        [Then(@"Page title should be '(.*)'")]
        public void ThenPageTitleShouldBe(string salesTitle)
        {
            _technicalPage.ValidateSalesTitle(salesTitle);
        }

        [Then(@"Validate the description text")]
        public void ThenValidateTheDescriptionText(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _technicalPage.ValidatePartNumberDescribtion(data.Description);
        }








    }
}
