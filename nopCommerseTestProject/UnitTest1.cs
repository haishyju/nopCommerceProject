using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nopCommerseTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using nopCommerseAutoFramework.Base;
using nopCommerseAutoFramework.Config;
using OpenQA.Selenium.IE;

namespace nopCommerseTestProject
{
	[TestClass]
	public class UnitTest1 : HookInitialize
	{
      /*  
        
        [TestMethod]
		public void TC1_Login()
		{

            CurrentPage = GetInstance<HomePage>();
            System.Threading.Thread.Sleep(4000);
            CurrentPage = CurrentPage.As<HomePage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("howareu", "123123");
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
            CurrentPage.As<AccountHomePage>().lnkLogout.Click();
            DriverContext.Driver.Close();
        }

		[TestMethod]
		public void TC2_Register()
		{
            CurrentPage = GetInstance<HomePage>();
            CurrentPage = CurrentPage.As<HomePage>().ClickRegister();
            CurrentPage.As<RegistrationPage>().Registration();

			DriverContext.Driver.Close();


		}

    */


	}
}
