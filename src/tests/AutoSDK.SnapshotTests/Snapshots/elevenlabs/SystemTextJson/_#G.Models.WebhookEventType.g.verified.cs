//HintName: G.Models.WebhookEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        CallInitiationFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType value)
        {
            return value switch
            {
                WebhookEventType.Transcript => "transcript",
                WebhookEventType.Audio => "audio",
                WebhookEventType.CallInitiationFailure => "call_initiation_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType? ToEnum(string value)
        {
            return value switch
            {
                "transcript" => WebhookEventType.Transcript,
                "audio" => WebhookEventType.Audio,
                "call_initiation_failure" => WebhookEventType.CallInitiationFailure,
                _ => null,
            };
        }
    }
}