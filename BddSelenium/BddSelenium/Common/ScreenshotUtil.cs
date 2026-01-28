using OpenQA.Selenium;

public static class ScreenshotUtil
{
    public static string CaptureScreenshot(IWebDriver driver, string fileName)
    {
        string screenshotDir = Path.Combine(Directory.GetCurrentDirectory(), "screenshots");
        Directory.CreateDirectory(screenshotDir);

        string filePath = Path.Combine(screenshotDir, fileName);

        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        screenshot.SaveAsFile(filePath);

        return filePath;
    }
}
