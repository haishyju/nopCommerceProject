using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace nopCommerseAutoFramework.Config
{
	public class ConfigReader
	{

		//public static string InitializeTest()
		//{
			//return ConfigurationManager.AppSettings["AUT"].ToString();
		//}

        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;

            string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();
            aut = navigator.SelectSingleNode("nopCommerseAutoFramwork/RunSettings/AUT");
            Settings.AUT = aut.ToString();
            
        }

	}
}
