using nopCommerseAutoFramework.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopCommerseAutoFramework.Base
{
    public abstract class BaseStep : Base
    {

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            DriverContext.Driver.Manage().Window.Maximize();
        }
    }
}
