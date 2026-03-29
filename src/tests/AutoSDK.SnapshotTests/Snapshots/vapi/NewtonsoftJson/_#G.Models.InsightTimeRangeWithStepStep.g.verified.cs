//HintName: G.Models.InsightTimeRangeWithStepStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by step for aggregation.<br/>
    /// If not provided, defaults to group by day.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InsightTimeRangeWithStepStep
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
        [global::System.Runtime.Serialization.EnumMember(Value="minute")]
        Minute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="quarter")]
        Quarter,
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
    public static class InsightTimeRangeWithStepStepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightTimeRangeWithStepStep value)
        {
            return value switch
            {
                InsightTimeRangeWithStepStep.Day => "day",
                InsightTimeRangeWithStepStep.Hour => "hour",
                InsightTimeRangeWithStepStep.Minute => "minute",
                InsightTimeRangeWithStepStep.Month => "month",
                InsightTimeRangeWithStepStep.Quarter => "quarter",
                InsightTimeRangeWithStepStep.Week => "week",
                InsightTimeRangeWithStepStep.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightTimeRangeWithStepStep? ToEnum(string value)
        {
            return value switch
            {
                "day" => InsightTimeRangeWithStepStep.Day,
                "hour" => InsightTimeRangeWithStepStep.Hour,
                "minute" => InsightTimeRangeWithStepStep.Minute,
                "month" => InsightTimeRangeWithStepStep.Month,
                "quarter" => InsightTimeRangeWithStepStep.Quarter,
                "week" => InsightTimeRangeWithStepStep.Week,
                "year" => InsightTimeRangeWithStepStep.Year,
                _ => null,
            };
        }
    }
}