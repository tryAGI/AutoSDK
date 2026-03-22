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
        ClientCancelled,
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        MaxOutputTokens,
        /// <summary>
        /// 
        /// </summary>
        TurnDetected,
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
                RealtimeResponseStatusDetailsReason.ClientCancelled => "client_cancelled",
                RealtimeResponseStatusDetailsReason.ContentFilter => "content_filter",
                RealtimeResponseStatusDetailsReason.MaxOutputTokens => "max_output_tokens",
                RealtimeResponseStatusDetailsReason.TurnDetected => "turn_detected",
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
                "client_cancelled" => RealtimeResponseStatusDetailsReason.ClientCancelled,
                "content_filter" => RealtimeResponseStatusDetailsReason.ContentFilter,
                "max_output_tokens" => RealtimeResponseStatusDetailsReason.MaxOutputTokens,
                "turn_detected" => RealtimeResponseStatusDetailsReason.TurnDetected,
                _ => null,
            };
        }
    }
}