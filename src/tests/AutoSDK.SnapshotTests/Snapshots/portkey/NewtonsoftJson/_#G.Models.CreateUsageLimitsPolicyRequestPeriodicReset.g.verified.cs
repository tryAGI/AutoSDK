//HintName: G.Models.CreateUsageLimitsPolicyRequestPeriodicReset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reset period. If not provided, limit is cumulative.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateUsageLimitsPolicyRequestPeriodicReset
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
    public static class CreateUsageLimitsPolicyRequestPeriodicResetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUsageLimitsPolicyRequestPeriodicReset value)
        {
            return value switch
            {
                CreateUsageLimitsPolicyRequestPeriodicReset.Monthly => "monthly",
                CreateUsageLimitsPolicyRequestPeriodicReset.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUsageLimitsPolicyRequestPeriodicReset? ToEnum(string value)
        {
            return value switch
            {
                "monthly" => CreateUsageLimitsPolicyRequestPeriodicReset.Monthly,
                "weekly" => CreateUsageLimitsPolicyRequestPeriodicReset.Weekly,
                _ => null,
            };
        }
    }
}