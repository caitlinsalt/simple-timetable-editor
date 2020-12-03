﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using Timetabler.CoreData;

namespace Timetabler.SerialData.Tests.Unit
{
    [TestClass]
    public class ExportOptionsModelUnitTests
    {
#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        public void ExportOptionsModelClass_IsPublic()
        {
            Type classType = typeof(ExportOptionsModel);
            Assert.IsTrue(classType.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_IsNotAbstract()
        {
            Type classType = typeof(ExportOptionsModel);
            Assert.IsFalse(classType.IsAbstract);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicParameterlessConstructor()
        {
            Type classType = typeof(ExportOptionsModel);
            ConstructorInfo constructor = classType.GetConstructor(Array.Empty<Type>());
            Assert.IsTrue(constructor.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicFontSetPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("FontSet");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicGraphsInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("GraphsInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicSetToWorkRowInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("SetToWorkRowInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicLocoToWorkRowInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("LocoToWorkRowInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicDisplayLocoDiagramRowPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("DisplayLocoDiagramRow");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicBoxHoursInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("BoxHoursInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicCreditsInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("CreditsInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicGlossaryInOutputPropertyOfTypeNullableBool()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("GlossaryInOutput");
            Assert.AreEqual(typeof(bool?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicLineWidthPropertyOfTypeNullableDouble()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("LineWidth");
            Assert.AreEqual(typeof(double?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicGraphAxisLineWidthPropertyOfTypeNullableDouble()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("GraphAxisLineWidth");
            Assert.AreEqual(typeof(double?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicFillerDashLineWidthPropertyOfTypeNullableDouble()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("FillerDashLineWidth");
            Assert.AreEqual(typeof(double?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicUpSectionLabelPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("UpSectionLabel");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicDownSectionLabelPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("DownSectionLabel");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicMorningLabelPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("MorningLabel");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicMiddayLabelPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("MiddayLabel");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicAfternoonLabelPropertyOfTypeString()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("AfternoonLabel");
            Assert.AreEqual(typeof(string), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

        [TestMethod]
        public void ExportOptionsModelClass_HasPublicDistancesInOutputPropertyOfTypeNullableSectionSelection()
        {
            Type classType = typeof(ExportOptionsModel);
            PropertyInfo property = classType.GetProperty("DistancesInOutput");
            Assert.AreEqual(typeof(SectionSelection?), property.PropertyType);
            Assert.IsTrue(property.GetMethod.IsPublic);
            Assert.IsTrue(property.SetMethod.IsPublic);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}
