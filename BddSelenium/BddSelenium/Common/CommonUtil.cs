using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace BddSelenium.Common
{
    public class CommonUtil
    {
        private static JObject _testData;
        private static JObject _configData;
        private static JObject _locatorData;

        // 🔹 Load Test Data JSON once
        public static void LoadTestData()
        {
            if (_testData == null)
            {
                try
                {
                    var jsonText = File.ReadAllText(Constants.TESTDATA_PATH);
                    _testData = JObject.Parse(jsonText);
                }
                catch (Exception ex)
                {
                    _testData = null;
                }
            }
        }

        // 🔹 Load Config JSON once
        public static void LoadConfig()
        {
            if (_configData == null)
            {
                var jsonText = File.ReadAllText(Constants.CONFIG_PATH);
                _configData = JObject.Parse(jsonText);
            }
        }

        public static void LoadLocators()
        {
            if (_locatorData == null)
            {
                var jsonText = File.ReadAllText(Constants.LOCATORS_PATH);
                _locatorData = JObject.Parse(jsonText);
            }
        }

        // 🔹 Get Test Data value
        public static string GetTestDataValue(string key)
        {
            if (_testData == null)
            {
                return key;
            }
            return _testData[key]?.ToString();
        }

        // 🔹 Get Config value
        public static string GetConfigValue(string key)
        {
            return _configData[key]?.ToString();
        }

        // 🔹 Typed getters for Config
        public static bool GetConfigBool(string key)
        {
            return _configData[key] != null && _configData[key].Value<bool>();
        }

        public static int GetConfigInt(string key)
        {
            return _configData[key] != null ? _configData[key].Value<int>() : 0;
        }
        public static string GetObjectData(string page, string key)
        {
            return _locatorData[page]?[key]?.ToString();
        }

    }

}
