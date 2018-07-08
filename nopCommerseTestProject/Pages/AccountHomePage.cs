using nopCommerseAutoFramework.Base;
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
	class AccountHomePage : BasePage
	{

		[FindsBy(How = How.XPath, Using = "//a[@class='ico-logout']")]
		public IWebElement lnkLogout { get; set; }

		public HomePage logout()
		{
			lnkLogout.Click();
			return new HomePage();
		}

        internal void CheckIfLogoutLinkExist()
        {
            lnkLogout.AssertElementPresent();
        }
    }
}
