using LIME.ApplicationLayer.Pages.Admin;
using LIME.Helper;
using LIME.Hooks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LIME.TestLayer.StepDefiniation.Admin
{
    [Binding]
    public sealed class DashboardSteps
    {
        public DashboardPage _dashboardPage;
        public DashboardSteps(WebDriver driver)
        {
            _dashboardPage = new DashboardPage(driver.Driver);
        }

        [Given(@"Navigate to Lime Home Page")]
        public void GivenNavigateToLimeHomePage()
        {
            _dashboardPage.NavigateToLime(HookInitialize.configSetting.BaseUrl);

        }

        [When(@"Admin is clicked on main menu")]
        public void WhenAdminIsClickedOnMainMenu()
        {
            _dashboardPage.NavigateToAdmin();
        }

        [When(@"Dashboard is selected")]
        public void WhenDashboardIsSelected()
        {
            _dashboardPage.ClickonDashboard();
        }

       

        [Then(@"General menu can be minimised / maximised and text links and icons are correctly displayed")]
        public void ThenGeneralMenuCanBeMinimisedMaximisedAndTextLinksAndIconsAreCorrectlyDisplayed(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _dashboardPage.DashboadValidation();
            _dashboardPage.ValidateGeneralText(data.UserLink, data.FeturesLink, data.PermissionLink);
            _dashboardPage.ValidateIcon();
        }



        [Then(@"Admin menu can be minimised/maximised/text links and icons are correctly displayed")]
        public void ThenAdminMenuCanBeMinimisedMaximisedTextLinksAndIconsAreCorrectlyDisplayed()
        {
            _dashboardPage.AdminValidation();
            _dashboardPage.validateAdminIcon();
        }



    }
}
