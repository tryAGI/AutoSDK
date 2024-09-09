//HintName: G.Models.GetBitsLeaderboardPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBitsLeaderboardPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
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