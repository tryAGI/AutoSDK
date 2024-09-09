//HintName: G.Models.UsageLimitType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of usage limit.
    /// </summary>
    public enum UsageLimitType2
    {
        /// <summary>
        /// 
        /// </summary>
        MonthlyTraces,
        /// <summary>
        /// 
        /// </summary>
        MonthlyLonglivedTraces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitType2 value)
        {
            return value switch
            {
                UsageLimitType2.MonthlyTraces => "monthly_traces",
                UsageLimitType2.MonthlyLonglivedTraces => "monthly_longlived_traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitType2? ToEnum(string value)
        {
            return value switch
            {
                "monthly_traces" => UsageLimitType2.MonthlyTraces,
                "monthly_longlived_traces" => UsageLimitType2.MonthlyLonglivedTraces,
                _ => null,
            };
        }
    }
}