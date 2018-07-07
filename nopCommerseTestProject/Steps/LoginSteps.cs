using nopCommerseAutoFramework.Base;
using nopCommerseTestProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace nopCommerseTestProject.Steps
{

    [Binding]
    public class LoginSteps : BaseStep
    {

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {

            // Navigate to site
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I clickon Login and I enter Username and Password")]
        public void WhenIClickonLoginAndIEnterUsernameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"click login button")]
        public void ThenClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the AccountHome Page")]
        public void ThenIShouldSeeTheAccountHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I click Logout")]
        public void ThenIClickLogout()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the Login page")]
        public void ThenIShouldSeeTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
