using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BddSelenium.Common
{
    public static class Assertion
    {

        // 🔹 IsTrue with message
        public static void IsTrue(bool condition, string message)
        {
            Assert.That(condition, Is.True, message);
        }

    }
}
