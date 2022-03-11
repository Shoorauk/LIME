using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIME.ApplicationLayer.Pages.Admin
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        By advance = By.Id("details-button");
        By continueHome = By.XPath("//*[text()='Continue to npqaweb.group.iqep.com (unsafe)']");
        By admin = By.XPath("//*[text()='Admin']");
        By dashboard = By.XPath("//li[@class='nav-item']/a[@href='/Admin']");
        By minimizeDashboard = By.XPath("//button[@class='accordion-button bg-secondary']");
        By maximizeDashboard = By.XPath("//button[@class='accordion-button bg-secondary collapsed']");
        By generalUsers = By.XPath("//div[@id='collapseOne']/div/div/a/div/div[2]");
        By generalFeature = By.XPath("//div[@id='collapseOne']/div/div/a[2]/div/div[2]");
        By generalPersmission = By.XPath("//div[@id='collapseOne']/div/div/a[3]/div/div[2]");
        By maximizeAdmin = By.XPath("//button[normalize-space()='Admin']");
        By otherFunctionText = By.XPath("//div[contains(text(),'Other Function')]");
        By usersIcon = By.XPath("//i[@class='fa fa-5x fa-users']");
        By questionIcon = By.XPath("//a[@href='/Admin/Features/List']//div[@class='border border-1 border-primary']");
        By permissionIcon = By.XPath("//i[@class='fa fa-5x fa-hand-stop-o']");
        By adminQuestionIcon = By.XPath("//a[@href='/Admin']//div[@class='border border-1 border-primary']//div[@class='text-center']//i[@class='fa fa-5x fa-question']");
            
        public void NavigateToLime(string url)
        {
            GoToUrl(url);
            ClickOnButton(advance);
            ClickOnButton(continueHome);

        }

        public void NavigateToAdmin()
        {
            ClickOnButton(admin);
        }

        public void ClickonDashboard()
        {
            ClickOnButton(dashboard);
        }

        public void DashboadValidation()
        {
            ClickOnButton(minimizeDashboard);
            ClickOnButton(maximizeDashboard);
        }


        public void ValidateGeneralText(string users,string features,string permissions)
        {
            Assert.AreEqual(getText(generalUsers), users);
            Assert.AreEqual(getText(generalFeature), features);
            Assert.AreEqual(getText(generalPersmission), permissions);

        }

        public void ValidateIcon()
        {
            Assert.True(getElement(usersIcon).Displayed);
            Assert.True(getElement(questionIcon).Displayed);
            Assert.True(getElement(permissionIcon).Displayed);

        }

        public void AdminValidation()
        {
            ClickOnButton(maximizeAdmin);
            ClickOnButton(maximizeAdmin);
            ClickOnButton(maximizeAdmin);
            Assert.AreEqual(getText(otherFunctionText), "Other Function");
        }

        public void validateAdminIcon()
        {
            Assert.True(getElement(adminQuestionIcon).Displayed);
        }

    }
}
