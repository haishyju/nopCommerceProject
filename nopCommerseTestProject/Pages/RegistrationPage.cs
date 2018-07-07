using nopCommerseAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace nopCommerseTestProject.Pages
{
	class RegistrationPage : BasePage
	{

		[FindsBy(How = How.XPath, Using = "//input[@value='Register']")]
		public IWebElement lnkRegister { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(@id,'FirstName')]")]
		public IWebElement enterFirstName { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(@id,'LastName')]")]
		public IWebElement enterLastName { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_Email']")]
		public IWebElement enterEmail { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(@id,'UserName')]")]
		public IWebElement enterUsername { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(@id,'Password')]")]
		public IWebElement enterPassword { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[contains(@id,'ConfirmPassword')]")]
		public IWebElement enterConfirmPassword { get; set; }

		[FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_cph1_cph1_ctrlCustomerRegister_CreateUserForm_CreateUserStepContainer_valSum']/ul/li[1]")]
		public IWebElement errorMessages { get; set; }


		public void Registration()
		{
            //String err_msg = errorMessages.Text;
            //Console.WriteLine(err_msg);
            submitRegistration();
            Thread.Sleep(5000);
			if (errorMessages.Text.Contains("First name"))
			{
				enterFirstName.SendKeys("xyzxyzxyz");
                submitRegistration();
			}
			
			//String err_msg = errorMessages.Text;
			if (errorMessages.Text.Contains("Last name"))
			{
				Thread.Sleep(2000);
				enterLastName.SendKeys("ANYTHING");
                submitRegistration();
				
			}

			
			if (errorMessages.Text.Contains("E-Mail"))
			{
				//DriverContext.Driver.Manage().Timeouts(TimeSpan, 5);
				enterEmail.SendKeys("vpshyjunair12@gmail.com");
                submitRegistration();
			}

			if (errorMessages.Text.Contains("Username"))
			{
				Thread.Sleep(2000);
				enterUsername.SendKeys("sdadsdsdsasas");
                submitRegistration();
			}
			if (errorMessages.Text.Contains("Password"))
			{
				Thread.Sleep(2000);
				enterPassword.SendKeys("12");
                submitRegistration();
			}

			if (errorMessages.Text.Contains("Confirm password"))
			{
				Thread.Sleep(2000);
				Console.WriteLine(errorMessages);
				enterConfirmPassword.SendKeys("12");
                submitRegistration();
			}

		}

		public void submitRegistration()
		{
			lnkRegister.Click();

		}



	}
}
