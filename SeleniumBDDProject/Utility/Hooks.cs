using System;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using System.Drawing.Imaging;

namespace SeleniumBDDProject.Utility
{
    [Binding]
    public class Hooks
    {
        private static ExtentReports extent;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentTest step;

        private static string reportBasePath = Path.Combine(Constants.ProjectDir, "Reports");
        private static string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        private static string reportPath = Path.Combine(reportBasePath, $"Report_{timeStamp}");
        private static string screenshotPath = Path.Combine(reportPath, "Screenshots");
        public static List<string> UserLogs = new List<string>();

        #region Before Hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Directory.CreateDirectory(reportPath);
            Directory.CreateDirectory(screenshotPath);

            var htmlReporter = new ExtentHtmlReporter(Path.Combine(reportPath, $"ExtentReport_{timeStamp}.html"));
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Config.DocumentTitle = "Automation Test Report";
            htmlReporter.Config.ReportName = "BDD Automation Execution";

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Console.WriteLine($"Starting Scenario: {scenarioContext.ScenarioInfo.Title}");
        }

        [BeforeStep]
        public void BeforeStep(ScenarioContext scenarioContext)
        {
            step = scenario.CreateNode(new GherkinKeyword(scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString()),
                                       scenarioContext.StepContext.StepInfo.Text);
        }

        #endregion

        #region After Hooks
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            string stepText = scenarioContext.StepContext.StepInfo.Text;
            string message = string.Join(Environment.NewLine, UserLogs);

            if (scenarioContext.TestError == null)
            {
                if (stepText.ToLower().Contains("verify") || WebManager.ENABLE_EACH_SCREENSHOT)
                {
                    string screenshotFile = TakeScreenshot(scenarioContext.ScenarioInfo.Title);
                    step.Pass(message)
                    .AddScreenCaptureFromPath(screenshotFile);
                }
            }
            else
            {
                string screenshotFile = TakeScreenshot(scenarioContext.ScenarioInfo.Title);
                step.Fail(scenarioContext.TestError.Message)
                    .AddScreenCaptureFromPath(screenshotFile);
            }
        }


        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine($"Ending Scenario: {scenarioContext.ScenarioInfo.Title}");
            WebManager.QuitBrowser();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }

        #endregion

        #region Helpers



        private string TakeScreenshot(string scenarioName, bool saveToFile = true)
        {
            string fileName = $"{scenarioName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string fullPath = Path.Combine(screenshotPath, fileName);

            string base64Screenshot = string.Empty;

            try
            {
                ITakesScreenshot ts = (ITakesScreenshot)WebManager.GetDriver;
                Screenshot screenshot = ts.GetScreenshot();

                // Convert to Base64
                base64Screenshot = screenshot.AsBase64EncodedString;

                if (saveToFile)
                {
                    screenshot.SaveAsFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Screenshot capture failed: " + ex.Message);
            }

            // Return Base64 if using inline, else return path
            return saveToFile ? fullPath : base64Screenshot;
        }


        private static string EmailBody(string message)
        {
            StringBuilder sbEmailBody = new StringBuilder();
            sbEmailBody.AppendLine("<!DOCTYPE html>");
            sbEmailBody.AppendLine("<html><head><meta charset='UTF-8' /><title>Automation Report</title></head><body>");
            sbEmailBody.AppendLine("<table style='border: 1px solid #000; background-color:#0486c0; color:#fff; padding:10px;'>");
            sbEmailBody.AppendLine($"<tr><td>Hi Team,</td></tr>");
            sbEmailBody.AppendLine($"<tr><td>{message}</td></tr>");
            sbEmailBody.AppendLine("<tr><td>Regards,<br>Automation Team</td></tr>");
            sbEmailBody.AppendLine("<tr><td><p style='color:#800000'>Note: This is an auto-generated email, please do not reply</p></td></tr>");
            sbEmailBody.AppendLine("</table></body></html>");
            return sbEmailBody.ToString();
        }

        #endregion
    }
}
