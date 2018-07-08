using nopCommerseAutoFramework.Base;
using nopCommerseTestProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        [Then(@"I enter Username and Password")]
        public void ThenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login("howareu", "123123");
        }
        
        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
        }
        
        [Then(@"I should see the AccountHome Page")]
        public void ThenIShouldSeeTheAccountHomePage()
        {
            CurrentPage.As<AccountHomePage>().CheckIfLogoutLinkExist();
        }
        
        [Then(@"I click Logout")]
        public void ThenIClickLogout()
        {
            CurrentPage = CurrentPage.As<AccountHomePage>().logout();
        }
    }
}
