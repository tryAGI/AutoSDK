//HintName: G.Models.RateLimitsUpdatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum RateLimitsUpdatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsUpdatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsUpdatedPayloadType value)
        {
            return value switch
            {
                RateLimitsUpdatedPayloadType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsUpdatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limits.updated" => RateLimitsUpdatedPayloadType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}