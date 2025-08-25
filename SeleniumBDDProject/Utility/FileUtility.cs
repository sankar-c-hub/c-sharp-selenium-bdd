using System.Xml.Linq;
using YamlDotNet.RepresentationModel;

namespace SeleniumBDDProject.Utility
{
    public class FileUtility
    {
        public static string GetConfigValue(string key)
        {
            try
            {
                var xml = XDocument.Load(Constants.ConfigurationPath);
                var element = xml.Root.Element(key);
                if (element != null)
                {
                    return element.Value;
                }
                return key;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading config value for '{key}': {ex.Message}");
            }
        }

        public static (string byType, string locatorValue)? GetLocatorFromYMLKey(string key)
        {
            try
            {
                // Path to locators.yml
                var yamlFile = Constants.ObjectRepoPath;
                if (!File.Exists(yamlFile))
                    throw new FileNotFoundException($"YAML file not found at {yamlFile}");

                // Load YAML
                using var reader = new StreamReader(yamlFile);
                var yaml = new YamlStream();
                yaml.Load(reader);

                var root = (YamlMappingNode)yaml.Documents[0].RootNode;

                // Split key by "."
                var parts = key.Split('.');
                if (parts.Length != 2)
                    throw new ArgumentException("Key must be in format 'SectionName.ElementName'");

                string section = parts[0];
                string element = parts[1];

                // Navigate YAML
                if (!root.Children.ContainsKey(section))
                    throw new Exception($"Section '{section}' not found in YAML");

                var sectionNode = (YamlMappingNode)root.Children[new YamlScalarNode(section)];

                if (!sectionNode.Children.ContainsKey(element))
                    throw new Exception($"Element '{element}' not found in section '{section}'");

                var elementNode = (YamlMappingNode)sectionNode.Children[new YamlScalarNode(element)];

                string by = elementNode.Children[new YamlScalarNode("by")].ToString();
                string value = elementNode.Children[new YamlScalarNode("value")].ToString();

                return (by, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading locator key '{key}': {ex.Message}");
                return null;
            }
        }
    }
}
