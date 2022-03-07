using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using LIME.Helper;
using OpenQA.Selenium.Edge;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using System.IO;
using LIME.Config;
using Microsoft.Extensions.Configuration;

namespace LIME.Hooks
{
    [Binding]
    public sealed class HookInitialize : WebDriver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public WebDriver _driver;

        public readonly FeatureContext _featureContext;
        public readonly ScenarioContext _scenarioContext;
        public ExtentTest _currentScenarioName;
        [ThreadStatic]
        public static ExtentTest featureName;
        public static ExtentTest step;
        public static AventStack.ExtentReports.ExtentReports extent;

        //static string  reportPath = "D:\\newgit\\SpecflowFramework\\UI_Script\\Result\\ExtentReport.html";
        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName +
            System.IO.Path.DirectorySeparatorChar + "Result\\ExtentReport.html";
        //static string logPath = "D:\\newgit\\SpecflowFramework\\UI_Script\\Result";
        static string logPath = System.IO.Directory.GetParent(@"../../../").FullName +
            System.IO.Path.DirectorySeparatorChar + "Result";
        //static string jsonfilePath = "D:\\newgit\\SpecflowFramework\\UI_Script\\Config\\APIParameters.json";
        //static string jsonfilePath = System.IO.Directory.GetParent(@"../../../").FullName +
        //    System.IO.Path.DirectorySeparatorChar + "Config//APIParameters.json";
        public static ConfigSetting configSetting;

        //static string configSettingPath = "D:\\newgit\\SpecflowFramework\\UI_Script\\Config\\configsetting.json";
       // public static TemplateConfigurations templateConfigurations { get; set; }
        //private static TemplateConfigurations templateConfigurations;

        static string configSettingPath = Directory.GetParent(@"../../../").FullName +
            Path.DirectorySeparatorChar + "Config/configsetting.json";

        public HookInitialize(WebDriver driver, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;

        }
        [BeforeTestRun]
        public static void TestInitilizer()
        {
            //Json File
            configSetting = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingPath);
            IConfigurationRoot configurationRoot = builder.Build();
            configurationRoot.Bind(configSetting);

            //Json file for parameter
            //using (StreamReader reader = File.OpenText(jsonfilePath))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    //templateConfigurations = (TemplateConfigurations)serializer.Deserialize(reader, typeof(TemplateConfigurations));
            //}


            //Reporting 
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);

            //Logging
            LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .WriteTo.File(logPath + @"\Logs",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} |{Level :u3} |{Message} {NewLine}",
                rollingInterval: RollingInterval.Day).CreateLogger();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            featureName = extent.CreateTest(context.FeatureInfo.Title);
            Log.Information("Selecting feature file {0} to run", context.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //_driver.Driver = new ChromeDriver();

            OpenQA.Selenium.Edge.EdgeOptions options = new EdgeOptions();
            _driver.Driver = new EdgeDriver(options);
            _currentScenarioName = featureName.CreateNode(context.ScenarioInfo.Title);

            Log.Information("Selecting feature file {0} to run", context.ScenarioInfo.Title);

        }

        [BeforeStep]
        public void BeforeStep()
        {
            step = _currentScenarioName;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                step.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {

                Log.Error("Test Step Failed |  " + context.TestError.Message);
                step.Log(Status.Fail, context.StepContext.StepInfo.Text, CaptureScreenShot());
            }

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Driver.Quit();
        }

        public MediaEntityModelProvider CaptureScreenShot()
        {
            var screenShot = ((OpenQA.Selenium.ITakesScreenshot)_driver.Driver).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot).Build();
        }
    }
}
