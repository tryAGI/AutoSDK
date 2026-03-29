//HintName: G.Models.UsageLimitsPolicyPeriodicReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reset period
    /// </summary>
    public enum UsageLimitsPolicyPeriodicReset
    {
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitsPolicyPeriodicResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitsPolicyPeriodicReset value)
        {
            return value switch
            {
                UsageLimitsPolicyPeriodicReset.Monthly => "monthly",
                UsageLimitsPolicyPeriodicReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitsPolicyPeriodicReset? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => UsageLimitsPolicyPeriodicReset.Monthly,
                "weekly" => UsageLimitsPolicyPeriodicReset.Weekly,
                _ => null,
            };
        }
    }
}