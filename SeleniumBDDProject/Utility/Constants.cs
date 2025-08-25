using System;
using System.IO;

namespace SeleniumBDDProject.Utility
{
    public class Constants
    {
        //project path
        public static readonly string ProjectDir = 
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;


        // Browser driver paths
        public static readonly string ChromeDriverPath =
            Path.Combine(ProjectDir, "Resources", "chromedriver.exe");

        public static readonly string FirefoxDriverPath =
            Path.Combine(ProjectDir, "Resources", "geckodriver.exe");

        public static readonly string EdgeDriverPath =
            Path.Combine(ProjectDir, "Resources", "msedgedriver.exe");

        public static readonly string ConfigurationPath =
            Path.Combine(ProjectDir, "Data", "Configuration.xml");

        public static readonly string ObjectRepoPath =
            Path.Combine(ProjectDir, "Data", "locators.yml");

    }
}
