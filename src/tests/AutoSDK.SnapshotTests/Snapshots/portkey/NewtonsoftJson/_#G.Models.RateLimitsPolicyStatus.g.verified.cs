//HintName: G.Models.RateLimitsPolicyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy status
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RateLimitsPolicyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archived")]
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsPolicyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsPolicyStatus value)
        {
            return value switch
            {
                RateLimitsPolicyStatus.Active => "active",
                RateLimitsPolicyStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsPolicyStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => RateLimitsPolicyStatus.Active,
                "archived" => RateLimitsPolicyStatus.Archived,
                _ => null,
            };
        }
    }
}