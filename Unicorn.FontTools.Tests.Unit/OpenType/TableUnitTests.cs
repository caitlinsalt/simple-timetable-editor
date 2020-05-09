﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Utility.Providers;
using Unicorn.FontTools.OpenType;
using Unicorn.FontTools.Tests.Unit.OpenType.Mocks;
using Unicorn.FontTools.Tests.Unit.TestHelpers;

namespace Unicorn.FontTools.Tests.Unit.OpenType
{
    [TestClass]
    public class TableUnitTests
    {
        private static readonly Random _rnd = RandomProvider.Default;

#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        public void TableClass_ConstructorWithTagParameter_SetsTableTagPropertyToValueOfParameter()
        {
            Tag testParam = _rnd.NextOpenTypeTag();

            MockTable testOutput = new MockTable(testParam);

            Assert.AreEqual(testParam, testOutput.TableTag);
        }

        [TestMethod]
        public void TableClass_ConstructorWithStringParameter_SetsTableTagPropertyToTagWithValueOfParameter()
        {
            Tag expectedValue = _rnd.NextOpenTypeTag();
            string testParam = expectedValue.Value;

            MockTable testOutput = new MockTable(testParam);

            Assert.AreEqual(expectedValue, testOutput.TableTag);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}