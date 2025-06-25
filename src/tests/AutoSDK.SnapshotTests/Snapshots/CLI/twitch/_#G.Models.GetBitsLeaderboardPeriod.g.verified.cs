﻿//HintName: G.Models.GetBitsLeaderboardPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBitsLeaderboardPeriod
    {
        /// <summary>
        /// 00:00 on the day specified in _started\_at_ and runs through 00:00:00 of the next day.
        /// </summary>
        Day,
        /// <summary>
        /// 00:00 on the Monday of the week specified in _started\_at_ and runs through 00:00:00 of the next Monday.
        /// </summary>
        Week,
        /// <summary>
        /// 00:00 on the first day of the month specified in _started\_at_ and runs through 00:00:00 of the first day of the next month.
        /// </summary>
        Month,
        /// <summary>
        /// 00:00 on the first day of the year specified in _started\_at_ and runs through 00:00:00 of the first day of the next year.
        /// </summary>
        Year,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBitsLeaderboardPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBitsLeaderboardPeriod value)
        {
            return value switch
            {
                GetBitsLeaderboardPeriod.Day => "day",
                GetBitsLeaderboardPeriod.Week => "week",
                GetBitsLeaderboardPeriod.Month => "month",
                GetBitsLeaderboardPeriod.Year => "year",
                GetBitsLeaderboardPeriod.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBitsLeaderboardPeriod? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetBitsLeaderboardPeriod.Day,
                "week" => GetBitsLeaderboardPeriod.Week,
                "month" => GetBitsLeaderboardPeriod.Month,
                "year" => GetBitsLeaderboardPeriod.Year,
                "all" => GetBitsLeaderboardPeriod.All,
                _ => null,
            };
        }
    }
}