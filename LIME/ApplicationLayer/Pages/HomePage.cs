using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIME.ApplicationLayer.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver):base(driver)
        {
            

        }

        By clickLanguage = By.XPath("//i[@class='flag-icon flag-icon-gb mt-1']");
        By selectCymbraeg = By.XPath("//span[normalize-space()='Cymraeg']");
        By checkCymbraegFlag = By.XPath("//i[@title='WLS']");
        By selectGB = By.XPath("//span[normalize-space()='English GB']");
        By checkGB = By.XPath("//i[@title='GB']");
        By selectUS = By.XPath("//span[normalize-space()='English US']");
        By checkUS = By.XPath("//i[@title='US']");
        By selectEspanol = By.XPath("//span[normalize-space()='Español']");
        By checkEspanol = By.XPath("//i[@title='ES']");
        By selectMandarin = By.XPath("//span[contains(text(),'中華民國')]");
        By checkMandarin = By.XPath("//i[@title='TW']");
        By clickNotificationIcon = By.XPath("//i[@class='fa fa-bell-o text-white']");
        By clickViewAllLink = By.XPath("//a[normalize-space()='View all']");
        By notificationHeaderTxt = By.XPath("//h3[normalize-space()='Notifications']");
        By clickOnProfileIcon = By.XPath("//img[@alt='profile']");
        By clickOnEditProfileLink = By.XPath("//span[normalize-space()='Edit Profile']");
        By editProfileHeaderTxt = By.XPath("//h1[normalize-space()='Edit Profile']");


        public void SelectLangauge()
        {
            ClickOnButton(clickLanguage);
        }

        public void SelectCymrage()
        {
            ClickOnButton(selectCymbraeg);
        }

        public void SelectGB()
        {
            ClickOnButton(selectGB);
        }
        public void SelectUS()
        {
            ClickOnButton(selectUS);
        }
        public void SelectEspanol()
        {
            ClickOnButton(selectEspanol);
        }
        public void SelectMandarin()
        {
            ClickOnButton(selectMandarin);
        }

        public void ValidateCymrage()
        {
            Assert.True(getElement(checkCymbraegFlag).Displayed);
        }

        public void ValidateGB()
        {
            Assert.True(getElement(checkGB).Displayed);
        }
        public void ValidateUS()
        {
            Assert.True(getElement(checkUS).Displayed);
        }

        public void ValidateEspanol()
        {
            Assert.True(getElement(checkEspanol).Displayed);
        }
        public void ValidateMandarin()
        {
            Assert.True(getElement(checkMandarin).Displayed);
        }

        public void ClickOnNotificationIcon()
        {
            ClickOnButton(clickNotificationIcon);
        }

        public void ClickOnViewAll()
        {
            ClickOnButton(clickViewAllLink);
        }

        public void ValidateNotificationHeader(string notificationText)
        {
            Assert.AreEqual(getText(notificationHeaderTxt), notificationText);
        }

        public void ClickOnProfileIcon()
        {
            ClickOnButton(clickOnProfileIcon);
        }

        public void ClickOneditProfileLink()
        {
            ClickOnButton(clickOnEditProfileLink);
        }

        public void ValidateEditProfileHeader(string editProfileTxt)
        {
            Assert.AreEqual(getText(editProfileHeaderTxt), editProfileTxt);
        }
    }
}
