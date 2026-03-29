//HintName: G.Models.UpdateUsageLimitsPolicyRequestPeriodicReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reset period. Set to null to remove periodic reset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateUsageLimitsPolicyRequestPeriodicReset
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
    public static class UpdateUsageLimitsPolicyRequestPeriodicResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUsageLimitsPolicyRequestPeriodicReset value)
        {
            return value switch
            {
                UpdateUsageLimitsPolicyRequestPeriodicReset.Monthly => "monthly",
                UpdateUsageLimitsPolicyRequestPeriodicReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUsageLimitsPolicyRequestPeriodicReset? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => UpdateUsageLimitsPolicyRequestPeriodicReset.Monthly,
                "weekly" => UpdateUsageLimitsPolicyRequestPeriodicReset.Weekly,
                _ => null,
            };
        }
    }
}