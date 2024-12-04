//HintName: G.Models.RealtimeServerEventRateLimitsUpdatedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `rate_limits.updated`.
    /// </summary>
    public enum RealtimeServerEventRateLimitsUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventRateLimitsUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventRateLimitsUpdatedType value)
        {
            return value switch
            {
                RealtimeServerEventRateLimitsUpdatedType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventRateLimitsUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limits.updated" => RealtimeServerEventRateLimitsUpdatedType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}