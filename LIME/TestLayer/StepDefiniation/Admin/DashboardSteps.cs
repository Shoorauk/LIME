using LIME.Hooks;
using System;

using TechTalk.SpecFlow;

namespace LIME.TestLayer.StepDefiniation.Admin
{
    [Binding]
    public sealed class DashboardSteps
    {


        [Given(@"Navigate to Lime Home Page")]
        public void GivenNavigateToLimeHomePage()
        {
            
            
            Console.WriteLine(HookInitialize.configSetting.BaseUrl);
        }

        [When(@"Admin is clicked on main menu")]
        public void WhenAdminIsClickedOnMainMenu()
        {
            Console.WriteLine("test");
        }

        [When(@"Dashboard is selected")]
        public void WhenDashboardIsSelected()
        {
            Console.WriteLine("test");
        }

        [Then(@"General menu can be minimised / maximised and text links and icons are correctly displayed")]
        public void ThenGeneralMenuCanBeMinimisedMaximisedAndTextLinksAndIconsAreCorrectlyDisplayed()
        {
            Console.WriteLine("test");
        }

        [Then(@"Admin menu can be minimised/maximised and text links and icons are correctly displayed")]
        public void ThenAdminMenuCanBeMinimisedMaximisedAndTextLinksAndIconsAreCorrectlyDisplayed()
        {
            Console.WriteLine("test2");
        }


    }
}
