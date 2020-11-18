﻿using System;
using Timetabler.Data;
using Timetabler.SerialData;

namespace Timetabler.DataLoader.Save
{
    /// <summary>
    /// YAML-related extension methods for the <see cref="DocumentOptions" /> class.
    /// </summary>
    public static class DocumentOptionsExtensions
    {
        /// <summary>
        /// Convert a <see cref="DocumentOptions" /> instance to a <see cref="DocumentOptionsModel" /> instance.
        /// </summary>
        /// <param name="options">The object to convert.</param>
        /// <returns>A <see cref="DocumentOptionsModel" /> instance containing the same data as the parameter in serialisable form.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the <c>this</c> parameter is <c>null</c>.</exception>
        public static DocumentOptionsModel ToDocumentOptionsModel(this DocumentOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            return new DocumentOptionsModel
            {
                ClockTypeName = Enum.GetName(typeof(ClockType), options.ClockType),
                DisplayTrainLabelsOnGraphs = options.DisplayTrainLabelsOnGraphs,
                GraphEditStyle = Enum.GetName(typeof(GraphEditStyle), options.GraphEditStyle),
                DisplaySpeedLinesOnGraphs = options.DisplaySpeedLinesOnGraphs,
                SpeedLineSpeed = options.SpeedLineSpeed,
                SpeedLineSpacingMinutes = options.SpeedLineSpacingMinutes,
                SpeedLineAppearance = options.SpeedLineAppearance?.ToGraphTrainPropertiesModel(),
            };
        }
    }
}
