﻿using System;
using Tests.Utility.Extensions;
using Timetabler.CoreData;

namespace Timetabler.Data.Tests.Utility.Extensions
{
    public static class RandomExtensions
    {

#pragma warning disable CA5394 // Do not use insecure randomness

        public static ClockType NextClockType(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }

            return (random.Next(2) == 0) ? ClockType.TwelveHourClock : ClockType.TwentyFourHourClock;
        }

        public static GraphEditStyle NextGraphEditStyle(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }

            GraphEditStyle[] styles = new[] { GraphEditStyle.Free, GraphEditStyle.PreserveSectionTimes };

            return styles[random.Next(styles.Length)];
        }

        public static Note NextNote(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }

            return new Note
            {
                AppliesToTimings = random.NextBoolean(),
                AppliesToTrains = random.NextBoolean(),
                DefinedInGlossary = random.NextBoolean(),
                DefinedOnPages = random.NextBoolean(),
                Definition = random.NextString(random.Next(50)),
                Id = random.NextHexString(8),
                Symbol = random.NextString(random.Next(1, 2)),
            };
        }

        public static GraphTrainProperties NextGraphTrainProperties(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }

            return new GraphTrainProperties
            {
                Colour = random.NextColour(),
                DashStyle = random.NextDashStyle(),
                Width = (float)(random.NextDouble() * random.Next(1, 4)),
            };
        }

        public static Colour NextColour(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }
            return new Colour(random.NextUInt());
        }

        public static DashStyle NextDashStyle(this Random random)
        {
            if (random is null)
            {
                throw new ArgumentNullException(nameof(random));
            }
            DashStyle[] allValues = new DashStyle[]
            {
                DashStyle.Dash,
                DashStyle.DashDot,
                DashStyle.DashDotDot,
                DashStyle.Dot,
                DashStyle.Solid,
            };
            return allValues[random.Next(allValues.Length)];
        }

#pragma warning restore CA5394 // Do not use insecure randomness

    }
}
