//HintName: G.Models.TimeRangeStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the time step for aggregations.<br/>
    /// If not provided, defaults to returning for the entire time range.
    /// </summary>
    public enum TimeRangeStep
    {
        /// <summary>
        /// 
        /// </summary>
        Century,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Decade,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Millennium,
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Quarter,
        /// <summary>
        /// 
        /// </summary>
        Second,
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
    public static class TimeRangeStepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeRangeStep value)
        {
            return value switch
            {
                TimeRangeStep.Century => "century",
                TimeRangeStep.Day => "day",
                TimeRangeStep.Decade => "decade",
                TimeRangeStep.Hour => "hour",
                TimeRangeStep.Millennium => "millennium",
                TimeRangeStep.Minute => "minute",
                TimeRangeStep.Month => "month",
                TimeRangeStep.Quarter => "quarter",
                TimeRangeStep.Second => "second",
                TimeRangeStep.Week => "week",
                TimeRangeStep.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeRangeStep? ToEnum(string value)
        {
            return value switch
            {
                "century" => TimeRangeStep.Century,
                "day" => TimeRangeStep.Day,
                "decade" => TimeRangeStep.Decade,
                "hour" => TimeRangeStep.Hour,
                "millennium" => TimeRangeStep.Millennium,
                "minute" => TimeRangeStep.Minute,
                "month" => TimeRangeStep.Month,
                "quarter" => TimeRangeStep.Quarter,
                "second" => TimeRangeStep.Second,
                "week" => TimeRangeStep.Week,
                "year" => TimeRangeStep.Year,
                _ => null,
            };
        }
    }
}