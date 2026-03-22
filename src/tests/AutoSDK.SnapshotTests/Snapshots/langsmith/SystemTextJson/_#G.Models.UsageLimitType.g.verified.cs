//HintName: G.Models.UsageLimitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of usage limit.
    /// </summary>
    public enum UsageLimitType
    {
        /// <summary>
        /// 
        /// </summary>
        MonthlyLonglivedTraces,
        /// <summary>
        /// 
        /// </summary>
        MonthlyTraces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitType value)
        {
            return value switch
            {
                UsageLimitType.MonthlyLonglivedTraces => "monthly_longlived_traces",
                UsageLimitType.MonthlyTraces => "monthly_traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitType? ToEnum(string value)
        {
            return value switch
            {
                "monthly_longlived_traces" => UsageLimitType.MonthlyLonglivedTraces,
                "monthly_traces" => UsageLimitType.MonthlyTraces,
                _ => null,
            };
        }
    }
}