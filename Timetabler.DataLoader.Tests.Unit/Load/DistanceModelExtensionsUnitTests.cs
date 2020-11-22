﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Utility.Providers;
using Timetabler.Data;
using Timetabler.DataLoader.Load;
using Timetabler.DataLoader.Tests.Unit.TestHelpers.Extensions;
using Timetabler.SerialData;

namespace Timetabler.DataLoader.Tests.Unit.Load
{
    [TestClass]
    public class DistanceModelExtensionsUnitTests
    {
        private static readonly Random _rnd = RandomProvider.Default;

#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DistanceModelExtensionsClass_ToDistanceMethod_ThrowsArgumentNullException_IfParameterIsNull()
        {
            DistanceModel testParam = null;

            testParam.ToDistance();

            Assert.Fail();
        }

        [TestMethod]
        public void DistanceModelExtensionsClass_ToDistanceMethod_ReturnsDistanceObjectWithCorrectMileageProperty_IfParameterIsNotNull()
        {
            DistanceModel testParam = _rnd.NextDistanceModel();

            Distance testOutput = testParam.ToDistance();

            Assert.AreEqual(testParam.Miles, testOutput.Mileage);
        }

        [TestMethod]
        public void DistanceModelExtensionsClass_ToDistanceMethod_ReturnsDistanceObjectWithCorrectChainageProperty_IfParameterIsNotNull()
        {
            DistanceModel testParam = _rnd.NextDistanceModel();

            Distance testOutput = testParam.ToDistance();

            Assert.AreEqual(testParam.Chains, testOutput.Chainage);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}