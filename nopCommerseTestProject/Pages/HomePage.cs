﻿using nopCommerseAutoFramework.Base;
using nopCommerseAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nopCommerseTestProject.Pages
{
	class HomePage : BasePage
	{

		[FindsBy(How = How.XPath,Using = "//a[@class='ico-login']")]
		public IWebElement lnkLogin { get; set; }

	  [FindsBy(How = How.XPath, Using = "//a[@class='ico-register']")]
		public IWebElement lnkRegister { get; set; }

	//	[FindsBy(How = How.Name, Using = "ctl00$ctl00$cph1$cph1$ctrlCustomerLogin$LoginForm$UserName")]
	//	 IWebElement txtUserId { get; set; }

	//	[FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_Password")]
	//	 IWebElement txtPasswd { get; set; }

    

       

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_cph1_cph1_ctrlCustomerLogin_LoginForm_LoginButton")]
		// IWebElement btnLogin { get; set; }
        public LoginPage ClickLoginLink()
        {
            lnkLogin.Click();
            return GetInstance<LoginPage>();
        }
		

		 //public AccountHomePage ClickLogin()
		//{
			//btnLogin.Click();
           // return GetInstance<AccountHomePage>();
		//}

		public RegistrationPage ClickRegister()
		{
			lnkRegister.Click();
			return new RegistrationPage();
		}

        internal void CheckIfLoginLinkExist()
        {
            lnkLogin.AssertElementPresent();
        }









    }
}
