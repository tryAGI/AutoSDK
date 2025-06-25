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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideosPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideosPeriod? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetVideosPeriod.All,
                "day" => GetVideosPeriod.Day,
                "month" => GetVideosPeriod.Month,
                "week" => GetVideosPeriod.Week,
                _ => null,
            };
        }
    }
}