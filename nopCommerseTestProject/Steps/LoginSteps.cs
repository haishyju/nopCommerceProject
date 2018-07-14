using nopCommerseAutoFramework.Base;
using nopCommerseTestProject.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace nopCommerseTestProject.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginLinkExist();
        }

        [When(@"I clickon Login")]
        public void WhenIClickonLogin()
        {
            CurrentPage = CurrentPage.As<HomePage>().ClickLoginLink();
        }

        [Then(@"I should see Loginpage")]
        public void ThenIShouldSeeLoginpage()
        {
            CurrentPage.As<LoginPage>().CheckIfLoginLinkExist();
        }

        [When(@"User enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            CurrentPage.As<LoginPage>().Login(credentials.Username, credentials.Password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
        }

        [Then(@"I should see the AccountHome Page")]
        public void ThenIShouldSeeTheAccountHomePage()
        {
            CurrentPage.As<AccountHomePage>().CheckIfLogoutLinkExist();
        }

        [Then(@"I clickon logout button")]
        public void ThenIClickonLogoutButton()
        {
           CurrentPage = CurrentPage.As<AccountHomePage>().logout();
        }

       
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

