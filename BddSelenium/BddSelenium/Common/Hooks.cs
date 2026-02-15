using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;

namespace BddSelenium.Common
{
    [Binding]
    public class Hooks
    {

        public static List<string> log = new List<string>();

        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest featureName;
        public static AventStack.ExtentReports.ExtentTest scenario, step, tags;

        // 🔹 Constructor injection (recommended)
        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            CommonUtil.LoadTestData();
            CommonUtil.LoadConfig();
            CommonUtil.LoadLocators();
            Console.WriteLine("===== TEST RUN STARTED =====");

            // Extent report setup
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string currentTime = DateTime.Now.ToString("HHmmss");
            string reportPath = Path.Combine(Constants.REPORT_PATH, $"{currentDate}_{currentTime}", "index.html");

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Config.CSS +=
                ".test-item .test-detail .name { white-space: normal !important; word-break: break-word; max-width: 70%; }" +
                ".test-item .test-detail .time { flex-shrink: 0; margin-left: 10px; }" +
                ".test-item .test-detail { display: flex; flex-wrap: wrap; align-items: flex-start; }" +
                ".node .name { white-space: normal !important; word-break: break-word; }";

            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine($"----- FEATURE STARTED: {featureContext.FeatureInfo.Title} -----");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;

            Console.WriteLine("BeforeScenario");
            string[] testTags = ScenarioContext.Current.ScenarioInfo.Tags;
            string allTags = "";
            for (int i = 0; i < testTags.Length; i++)
            {
                allTags = allTags + ", " + testTags[i];
            }
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            tags = scenario.CreateNode<Scenario>("Tags: " + allTags.TrimStart(','));
            Console.WriteLine($"--- SCENARIO STARTED: {_scenarioContext.ScenarioInfo.Title} ---");
        }

        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
            Console.WriteLine($"STEP STARTED: {_scenarioContext.StepContext.StepInfo.Text}");
        }

        [AfterStep]
        public void AfterStep()
        {
            string log = string.Join(Environment.NewLine, Hooks.log);
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            var stepname = ScenarioStepContext.Current.StepInfo.Text;
            var completestep = stepType + " " + stepname;
            bool takeScreenshot = CommonUtil.GetConfigBool("EnableScreenshotForAllSteps") || stepname.ToLower().Contains("verify");

            if (takeScreenshot)
            {
                string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"{timeStamp}.png";
                string screenshotPath = ScreenshotUtil.CaptureScreenshot(BrowserManager.Driver, fileName);

                MediaEntityModelProvider media =
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build();
                scenario.CreateNode<Given>(completestep).Pass(log.Replace("\n", "<br>"), media);
            }
            else
            {
                scenario.CreateNode<Given>(completestep).Pass(log.Replace("\n", "<br>"));

            }
            Hooks.log.Clear();
        }



        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine($"--- SCENARIO ENDED: {_scenarioContext.ScenarioInfo.Title} ---");
            Console.WriteLine($"STATUS: {_scenarioContext.ScenarioExecutionStatus}");
            BrowserManager.CloseBrowser();

        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"----- FEATURE ENDED: {featureContext.FeatureInfo.Title} -----");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
            Console.WriteLine("===== TEST RUN COMPLETED =====");
        }
    }
}

