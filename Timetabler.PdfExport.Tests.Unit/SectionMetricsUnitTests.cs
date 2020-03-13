﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tests.Utility.Providers;
using Unicorn.Interfaces;

namespace Timetabler.PdfExport.Tests.Unit
{
    [TestClass]
    public class SectionMetricsUnitTests
    {
        private static readonly Random _rnd = RandomProvider.Default;

#pragma warning disable CA1707 // Identifiers should not contain underscores

        [TestMethod]
        public void SectionMetricsClass_Constructor_SetsLineWidthPropertyToValueOfParameter()
        {
            double testParam0 = _rnd.NextDouble() * 10;

            SectionMetrics testOutput = new SectionMetrics(testParam0);

            Assert.AreEqual(testParam0, testOutput.LineWidth);
        }

        [TestMethod]
        public void SectionMetricsClass_TotalHeightProperty_EqualsHeaderHeightPropertyPlusToWorkHeightPropertyPlusLocoToWorkHeightPropertyPlusTitleHeightPropertyPlusSubtitleHeightPropertyPlusLineWidthPropertyPlusHeightPropertyOfTotalSizePropertyOfMainSectionMetricsProperty()
        {
            double headerHeight = _rnd.NextDouble() * 10;
            double toWorkHeight = _rnd.NextDouble() * 10;
            double locoToWorkHeight = _rnd.NextDouble() * 10;
            double titleHeight = _rnd.NextDouble() * 10;
            double subTitleHeight = _rnd.NextDouble() * 10;
            double lineWidth = _rnd.NextDouble() * 5;
            double mainSectionMetricsHeight = _rnd.NextDouble() * 200;
            SectionMetrics testObject = new SectionMetrics(lineWidth)
            {
                HeaderHeight = headerHeight,
                ToWorkHeight = toWorkHeight,
                LocoToWorkHeight = locoToWorkHeight,
                TitleHeight = titleHeight,
                SubtitleHeight = subTitleHeight,
                MainSectionMetrics = new LocationBoxDimensions
                {
                    TotalSize = new UniSize(_rnd.NextDouble() * 500, mainSectionMetricsHeight)
                }
            };

            double testOutput = testObject.TotalHeight;

            double expectedValue = headerHeight + toWorkHeight + locoToWorkHeight + titleHeight + subTitleHeight + lineWidth + mainSectionMetricsHeight;
            Assert.AreEqual(expectedValue, testOutput, 0.0000000001);
        }

#pragma warning restore CA1707 // Identifiers should not contain underscores

    }
}
