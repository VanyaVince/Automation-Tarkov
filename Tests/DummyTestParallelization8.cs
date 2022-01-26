using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.Tests
{
    public class DummyTestParallelization8 : BaseTest
    {
        [Test]
        public void OpenGooglePageTest8()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");

            Assert.Pass();
        }
    }
}
