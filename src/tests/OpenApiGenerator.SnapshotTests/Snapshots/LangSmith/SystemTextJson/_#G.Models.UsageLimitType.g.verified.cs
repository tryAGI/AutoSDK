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
        MonthlyTraces,
        /// <summary>
        /// 
        /// </summary>
        MonthlyLonglivedTraces,
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
                UsageLimitType.MonthlyTraces => "monthly_traces",
                UsageLimitType.MonthlyLonglivedTraces => "monthly_longlived_traces",
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
                "monthly_traces" => UsageLimitType.MonthlyTraces,
                "monthly_longlived_traces" => UsageLimitType.MonthlyLonglivedTraces,
                _ => null,
            };
        }
    }
}