﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Utility.Providers;
using Timetabler.Data;
using Timetabler.Data.Tests.Utility.Extensions;
using Timetabler.DataLoader.Save;
using Timetabler.SerialData;

namespace Timetabler.DataLoader.Tests.Unit.Save
{
    [TestClass]
    public class NoteExtensionsUnitTests
    {
        private static readonly Random _rnd = RandomProvider.Default;

        private static Note GetTestObject()
        {
            return _rnd.NextNote();
        }

#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NoteExtensionsClass_ToNoteModelMethod_ThrowsArgumentNullException_IfParameterIsNull()
        {
            Note testParam = null;

            _ = testParam.ToNoteModel();

            Assert.Fail();
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectIdProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.Id, testOutput.Id);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectSymbolProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.Symbol, testOutput.Symbol);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectAppliesToTimingsProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.AppliesToTimings, testOutput.AppliesToTimings);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectAppliesToTrainsProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.AppliesToTrains, testOutput.AppliesToTrains);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectDefinedInGlossaryProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.DefinedInGlossary, testOutput.DefinedInGlossary);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectDefinedOnPagesProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.DefinedOnPages, testOutput.DefinedOnPages);
        }

        [TestMethod]
        public void NoteExtensionsClass_ToNoteModelMethod_ReturnsObjectWithCorrectDefinitionProperty_IfParameterIsNotNull()
        {
            Note testParam = GetTestObject();

            NoteModel testOutput = testParam.ToNoteModel();

            Assert.AreEqual(testParam.Definition, testOutput.Definition);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}