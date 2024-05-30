//HintName: G.Models.GetVideosPeriod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVideosPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    public static class GetVideosPeriodExtensions
    {
        public static string ToValueString(this GetVideosPeriod value)
        {
            return value switch
            {
                GetVideosPeriod.All => "all",
                GetVideosPeriod.Day => "day",
                GetVideosPeriod.Month => "month",
                GetVideosPeriod.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosPeriod ToEnum(string value)
        {
            return value switch
            {
                "all" => GetVideosPeriod.All,
                "day" => GetVideosPeriod.Day,
                "month" => GetVideosPeriod.Month,
                "week" => GetVideosPeriod.Week,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetVideosPeriod ToEnum(int value)
        {
            return value switch
            {
                0 => GetVideosPeriod.All,
                1 => GetVideosPeriod.Day,
                2 => GetVideosPeriod.Month,
                3 => GetVideosPeriod.Week,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}