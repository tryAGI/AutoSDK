//HintName: G.Models.GetBitsLeaderboardPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetBitsLeaderboardPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="year")]
        Year,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    public static class GetBitsLeaderboardPeriodExtensions
    {
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
        public static GetBitsLeaderboardPeriod ToEnum(string value)
        {
            return value switch
            {
                "day" => GetBitsLeaderboardPeriod.Day,
                "week" => GetBitsLeaderboardPeriod.Week,
                "month" => GetBitsLeaderboardPeriod.Month,
                "year" => GetBitsLeaderboardPeriod.Year,
                "all" => GetBitsLeaderboardPeriod.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetBitsLeaderboardPeriod ToEnum(int value)
        {
            return value switch
            {
                0 => GetBitsLeaderboardPeriod.Day,
                1 => GetBitsLeaderboardPeriod.Week,
                2 => GetBitsLeaderboardPeriod.Month,
                3 => GetBitsLeaderboardPeriod.Year,
                4 => GetBitsLeaderboardPeriod.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}