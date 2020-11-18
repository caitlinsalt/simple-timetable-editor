﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Utility.Extensions;
using Tests.Utility.Providers;
using Timetabler.Data;
using Timetabler.DataLoader.Load;
using Timetabler.SerialData;

namespace Timetabler.DataLoader.Tests.Unit.Load
{
    [TestClass]
    public class SignalboxModelExtensionsUnitTests
    {
        private static readonly Random _rnd = RandomProvider.Default;

#pragma warning disable CA5394 // Do not use insecure randomness

        private static SignalboxModel GetModel() => new SignalboxModel
        {
            Id = _rnd.NextHexString(8),
            Code = _rnd.NextString(_rnd.Next(10)),
            EditorDisplayName = _rnd.NextString(_rnd.Next(32)),
            TimetableDisplayName = _rnd.NextString(_rnd.Next(32)),
        };

#pragma warning restore CA5394 // Do not use insecure randomness

#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ThrowsArgumentNullException_IfParameterIsNull()
        {
            SignalboxModel testParam = null;

            _ = testParam.ToSignalbox();

            Assert.Fail();
        }

        [TestMethod]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ReturnsObjectWithCorrectIdProperty_IfParameterIsNotNull()
        {
            SignalboxModel testParam = GetModel();

            Signalbox testOutput = testParam.ToSignalbox();

            Assert.AreEqual(testParam.Id, testOutput.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ThrowsArgumentException_IfParameterIsNotNullAndIdPropertyOfParameterIsNull()
        {
            SignalboxModel testParam = GetModel();
            testParam.Id = null;

            _ = testParam.ToSignalbox();

            Assert.Fail();
        }

        [TestMethod]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ReturnsObjectWithCorrectCodeProperty_IfParameterIsNotNull()
        {
            SignalboxModel testParam = GetModel();

            Signalbox testOutput = testParam.ToSignalbox();

            Assert.AreEqual(testParam.Code, testOutput.Code);
        }

        [TestMethod]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ReturnsObjectWithCorrectEditorDisplayNameProperty_IfParameterIsNotNull()
        {
            SignalboxModel testParam = GetModel();

            Signalbox testOutput = testParam.ToSignalbox();

            Assert.AreEqual(testParam.EditorDisplayName, testOutput.EditorDisplayName);
        }

        [TestMethod]
        public void SignalboxModelExtensionsClass_ToSignalboxMethod_ReturnsObjectWithCorrectExportDisplayNameProperty_IfParameterIsNotNull()
        {
            SignalboxModel testParam = GetModel();

            Signalbox testOutput = testParam.ToSignalbox();

            Assert.AreEqual(testParam.TimetableDisplayName, testOutput.ExportDisplayName);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}
