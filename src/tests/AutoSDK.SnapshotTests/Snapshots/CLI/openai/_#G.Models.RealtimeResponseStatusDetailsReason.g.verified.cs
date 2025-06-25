//HintName: G.Models.RealtimeResponseStatusDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason the Response did not complete. For a `cancelled` Response, <br/>
    /// one of `turn_detected` (the server VAD detected a new start of speech) <br/>
    /// or `client_cancelled` (the client sent a cancel event). For an <br/>
    /// `incomplete` Response, one of `max_output_tokens` or `content_filter` <br/>
    /// (the server-side safety filter activated and cut off the response).
    /// </summary>
    public enum RealtimeResponseStatusDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        TurnDetected,
        /// <summary>
        /// 
        /// </summary>
        ClientCancelled,
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseStatusDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseStatusDetailsReason value)
        {
            return value switch
            {
                RealtimeResponseStatusDetailsReason.TurnDetected => "turn_detected",
                RealtimeResponseStatusDetailsReason.ClientCancelled => "client_cancelled",
                RealtimeResponseStatusDetailsReason.MaxOutputTokens => "max_output_tokens",
                RealtimeResponseStatusDetailsReason.ContentFilter => "content_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseStatusDetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "turn_detected" => RealtimeResponseStatusDetailsReason.TurnDetected,
                "client_cancelled" => RealtimeResponseStatusDetailsReason.ClientCancelled,
                "max_output_tokens" => RealtimeResponseStatusDetailsReason.MaxOutputTokens,
                "content_filter" => RealtimeResponseStatusDetailsReason.ContentFilter,
                _ => null,
            };
        }
    }
}