using BoDi;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using TechTalk.SpecFlow;
using uLTechTest.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace uLTechTest.Hooks
{
    [Binding]
    public sealed class Hooks : DriverHelper
    {
        IObjectContainer container;
        public Hooks(IObjectContainer _container)
        {
            container = _container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            container.RegisterInstanceAs(Driver);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Driver?.Quit();
            using (var process = Process.GetCurrentProcess())
            {
                if (process.ToString() == "chromedriver")
                {
                    process.Kill(true);
                }
                Driver?.Dispose(); Driver = null;
            }
        }
    }
}