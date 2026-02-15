namespace BddSelenium.Common
{
    [Serializable]
    class CustomException : Exception
    {
        string mainStackTrace = string.Empty;
        public CustomException()
        {
        }
        public CustomException(string message, Exception innerException, string optionalText = "") : base(message, innerException)
        {
            string actualStackTrace = Environment.StackTrace;
            string[] stackTraceArray = actualStackTrace.Split(new string[] { "at" }, StringSplitOptions.None);
            for (int i = 0; i < stackTraceArray.Count(); i++)
            {
                if (stackTraceArray[i].Contains("AlgoAfScripts.WorkFlows"))
                {
                    if (optionalText != "")
                    {
                        mainStackTrace = "Xpath: " + optionalText + "\nStackTrace: " + stackTraceArray[i];
                    }
                    else
                    {
                        mainStackTrace = "StackTrace: " + stackTraceArray[i];
                    }
                }
            }
        }
        public CustomException(string message, string optionalText = "") : base(message)
        {
            string actualStackTrace = Environment.StackTrace;
            string[] stackTraceArray = actualStackTrace.Split(new string[] { "at" }, StringSplitOptions.None);
            for (int i = 0; i < stackTraceArray.Count(); i++)
            {
                if (stackTraceArray[i].Contains("AlgoAfScripts.WorkFlows"))
                {
                    if (optionalText != "")
                    {
                        mainStackTrace = "Xpath: " + optionalText + "\nStackTrace: " + stackTraceArray[i];
                    }
                    else
                    {
                        mainStackTrace = "StackTrace: " + stackTraceArray[i];
                    }
                }
            }
        }
        public override string StackTrace
        {
            get
            {
                return mainStackTrace;
            }
        }
    }
}
