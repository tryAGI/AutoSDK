//HintName: G.Models.UsageLimitsPeriodicReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reset the usage periodically.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageLimitsPeriodicReset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monthly")]
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weekly")]
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitsPeriodicResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitsPeriodicReset value)
        {
            return value switch
            {
                UsageLimitsPeriodicReset.Monthly => "monthly",
                UsageLimitsPeriodicReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitsPeriodicReset? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => UsageLimitsPeriodicReset.Monthly,
                "weekly" => UsageLimitsPeriodicReset.Weekly,
                _ => null,
            };
        }
    }
}