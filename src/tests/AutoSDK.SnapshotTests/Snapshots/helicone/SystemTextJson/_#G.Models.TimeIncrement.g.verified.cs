//HintName: G.Models.TimeIncrement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimeIncrement
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeIncrementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeIncrement value)
        {
            return value switch
            {
                TimeIncrement.Day => "day",
                TimeIncrement.Hour => "hour",
                TimeIncrement.Min => "min",
                TimeIncrement.Month => "month",
                TimeIncrement.Week => "week",
                TimeIncrement.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeIncrement? ToEnum(string value)
        {
            return value switch
            {
                "day" => TimeIncrement.Day,
                "hour" => TimeIncrement.Hour,
                "min" => TimeIncrement.Min,
                "month" => TimeIncrement.Month,
                "week" => TimeIncrement.Week,
                "year" => TimeIncrement.Year,
                _ => null,
            };
        }
    }
}