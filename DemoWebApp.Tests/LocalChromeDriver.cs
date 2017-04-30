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
        public LocalChromeDriver() : base(@"C:\Users\Robert\Desktop")
        {

        }
    }
}
