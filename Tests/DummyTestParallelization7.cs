﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkov.Tests
{
    public class DummyTestParallelization7 : BaseTest
    {
        [Test]
        public void OpenGooglePageTest7()
        {
            Driver.Navigate().GoToUrl("https://www.google.com/");

            Assert.Pass();
        }
    }
}
