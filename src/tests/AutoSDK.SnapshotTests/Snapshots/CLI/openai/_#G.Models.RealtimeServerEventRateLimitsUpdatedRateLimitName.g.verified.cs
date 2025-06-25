//HintName: G.Models.RealtimeServerEventRateLimitsUpdatedRateLimitName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the rate limit (`requests`, `tokens`).
    /// </summary>
    public enum RealtimeServerEventRateLimitsUpdatedRateLimitName
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventRateLimitsUpdatedRateLimitNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventRateLimitsUpdatedRateLimitName value)
        {
            return value switch
            {
                RealtimeServerEventRateLimitsUpdatedRateLimitName.Requests => "requests",
                RealtimeServerEventRateLimitsUpdatedRateLimitName.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventRateLimitsUpdatedRateLimitName? ToEnum(string value)
        {
            return value switch
            {
                "requests" => RealtimeServerEventRateLimitsUpdatedRateLimitName.Requests,
                "tokens" => RealtimeServerEventRateLimitsUpdatedRateLimitName.Tokens,
                _ => null,
            };
        }
    }
}