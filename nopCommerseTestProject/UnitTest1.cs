using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nopCommerseTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using nopCommerseAutoFramework.Base;
using nopCommerseAutoFramework.Helpers;
using nopCommerseAutoFramework.Config;
using OpenQA.Selenium.IE;
using System.Threading;

namespace nopCommerseTestProject
{
	[TestClass]
	public class UnitTest1 : HookInitialize
	{
        
      
        [TestMethod]
		public void TC1_UserLogin()
		{
            //string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\TestData.xlsx";
            //string fileName  = @"C:\\Users\\vpshy\\source\\repos\\nopCommerse\\nopCommerseTestProject\\Data\\TestData.xlsx";
           
           
            CurrentPage = GetInstance<HomePage>();
            LogHelpers.Write("Opened the browser and navigated to Home Page !!!");
            CurrentPage = CurrentPage.As<HomePage>().ClickLoginLink();
           LogHelpers.Write("Clicked on LoginLink from HomePage !!!");
            CurrentPage.As<LoginPage>().Login("howareu","123123");
           LogHelpers.Write("Entered UserName and Password !!!");
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
           LogHelpers.Write("Clicked on login after entering UserName and Password !!!");
            CurrentPage = CurrentPage.As<AccountHomePage>().logout();
            LogHelpers.Write("Login Successful and logged out");
            CurrentPage.As<LoginPage>().CheckIfLoginLinkExist();
            DriverContext.Driver.Close();
        }

		[TestMethod]
		public void TC2_UserRegistration()
		{
            //Precondition : UserName should not exist.
            CurrentPage = GetInstance<HomePage>();
           // LogHelpers.Write("Opened the browser and navigated to Home Page !!!");
            CurrentPage = CurrentPage.As<HomePage>().ClickRegister();
           // LogHelpers.Write("Found the registration Link and clicked on it !!!");
            CurrentPage.As<RegistrationPage>().Registration();
           // LogHelpers.Write("Tested the mandatory fields and submitted the registration !!!");

            DriverContext.Driver.Close();


		}

    
    

	}

    
}
