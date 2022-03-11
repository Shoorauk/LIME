using LIME.ApplicationLayer.Pages;
using LIME.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LIME.TestLayer.StepDefiniation.Admin
{
    [Binding]
    public sealed class HomeSteps
    {
        private HomePage _homePage;

        public HomeSteps(WebDriver driver)
        {
            _homePage = new HomePage(driver.Driver);
        }

        [When(@"Language flag is clicked")]
        public void WhenLanguageFlagIsClicked()
        {
            _homePage.SelectLangauge();
        }

        [When(@"select the (.*) language")]
        public void WhenSelectTheLanguage(string p0)
        {
            _homePage.SelectCymrage();
        }

        [Then(@"The flag icon changes to the Welsh flag")]
        public void ThenTheFlagIconChangesToTheWelshFlag()
        {
            _homePage.ValidateCymrage();
        }

        [When(@"English GB is selected")]
        public void WhenEnglishGBIsSelected()
        {
            _homePage.SelectGB();
        }

        [Then(@"The flag icon changes to the English flag")]
        public void ThenTheFlagIconChangesToTheEnglishFlag()
        {
            _homePage.ValidateGB();
        }

        [When(@"English US is selected")]
        public void WhenEnglishUSIsSelected()
        {
            _homePage.SelectUS();
        }

        [Then(@"The flag icon changes to the American flag")]
        public void ThenTheFlagIconChangesToTheAmericanFlag()
        {
            _homePage.ValidateUS();
        }


        [When(@"Espanol is selected")]
        public void WhenEspanolIsSelected()
        {
            _homePage.SelectEspanol();
        }

        [Then(@"The flag icon changes to the Spanish flag")]
        public void ThenTheFlagIconChangesToTheSpanishFlag()
        {
            _homePage.ValidateEspanol();
        }

        [When(@"Mandarin is selected")]
        public void WhenMandarinIsSelected()
        {
            _homePage.SelectMandarin();
        }

        [Then(@"The flag icon changes to the Taiwan flag")]
        public void ThenTheFlagIconChangesToTheTaiwanFlag()
        {
            _homePage.ValidateMandarin();
        }

        [When(@"Notifications icon is clicked")]
        public void WhenNotificationsIconIsClicked()
        {
            _homePage.ClickOnNotificationIcon();
        }

        [When(@"View All is clicked")]
        public void WhenViewAllIsClicked()
        {
            _homePage.ClickOnViewAll();
        }

        [Then(@"Validate that page header is Notifications (.*)")]
        public void ThenValidateThatPageHeaderIsNotifications(string notificationTxt)
        {
            _homePage.ValidateNotificationHeader(notificationTxt);
        }

        [When(@"Profile icon is clicked")]
        public void WhenProfileIconIsClicked()
        {
            _homePage.ClickOnProfileIcon();
        }

        [When(@": Edit Profile is clicked")]
        public void WhenEditProfileIsClicked()
        {
            _homePage.ClickOneditProfileLink();
        }

        [Then(@"Header text on page is '(.*)'")]
        public void ThenHeaderTextOnPageIs(string editProfileTxt)
        {
            _homePage.ValidateEditProfileHeader(editProfileTxt);
        }






    }
}
