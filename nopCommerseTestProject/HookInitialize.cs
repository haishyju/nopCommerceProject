using nopCommerseAutoFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace nopCommerseTestProject
{

       [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize(): base(BrowserType.Chrome)
        {
            InitializeSttings();
            
            NavigateSite();
        }
        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();

        }
        
    }
}
