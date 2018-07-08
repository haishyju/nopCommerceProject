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

        public static void SetFrameworkSettings()
        {

            XPathItem aut;
            XPathItem testtype;
            XPathItem islog;
            XPathItem logPath;

            string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFileName, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();
            aut = navigator.SelectSingleNode("nopCommerseAutoFramwork/RunSettings/AUT");
            islog = navigator.SelectSingleNode("nopCommerseAutoFramwork/RunSettings/IsLog");
            logPath = navigator.SelectSingleNode("nopCommerseAutoFramwork/RunSettings/LogPath");

            Settings.AUT = aut.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();

        }

    }
}