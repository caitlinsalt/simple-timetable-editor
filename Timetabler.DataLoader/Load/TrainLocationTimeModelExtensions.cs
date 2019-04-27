﻿using System.Collections.Generic;
using Timetabler.Data;
using Timetabler.XmlData;

namespace Timetabler.DataLoader.Load
{
    /// <summary>
    /// Extension methods for loading a TrainLocationTime instance from serializable form.
    /// </summary>
    public static class TrainLocationTimeModelExtensions
    {
        /// <summary>
        /// Convert a <see cref="TrainLocationTimeModel"/> instance into a <see cref="TrainLocationTime"/> instance, normalising the location and footnote fields if possible.
        /// </summary>
        /// <param name="model">The model instance to convert.</param>
        /// <param name="locations">Location map.</param>
        /// <param name="notes">Timetable footnotes.</param>
        /// <returns>A converted <see cref="TrainLocationTime"/> instance.</returns>
        public static TrainLocationTime ToTrainLocationTime(this TrainLocationTimeModel model, Dictionary<string, Location> locations, Dictionary<string, Note> notes, DocumentOptions options)
        {
            if (model == null)
            {
                return null;
            }

            TrainLocationTime output = new TrainLocationTime
            {
                Pass = model.Pass,
                ArrivalTime = model.ArrivalTime != null ? model.ArrivalTime.ToTrainTime(notes) : null,
                DepartureTime = model.DepartureTime != null ? model.DepartureTime.ToTrainTime(notes) : null,
                Path = model.Path,
                Platform = model.Platform,
                Line = model.Line,
                FormattingStrings = options.FormattingStrings,
            };

            if (model.LocationId != null && locations != null && locations.ContainsKey(model.LocationId))
            {
                output.Location = locations[model.LocationId];
            }

            return output;
        }
    }
}
