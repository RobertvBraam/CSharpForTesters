using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Tests
{
    public class LocalChromeDriver : ChromeDriver
    {
        private static ChromeOptions options {
            get
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("test-type");
                options.AddArgument("start-maximized");
                options.AddArgument("--js-flags=--expose-gc");
                options.AddArgument("--enable-precise-memory-info");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--disable-default-apps");
                options.AddArgument("test-type=browser");
                options.AddArgument("disable-infobars");
                return options;
            }
        }

        public LocalChromeDriver() : base(@"C:\Users\RobertvBraam\Desktop", options)
        {
        }
    }
}
