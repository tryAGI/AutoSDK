//HintName: G.Models.TimeIncrement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TimeIncrement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hour")]
        Hour,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="min")]
        Min,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="year")]
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