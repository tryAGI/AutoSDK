//HintName: G.Models.WebhookTranscriptionCreatedPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transcription.created<br/>
    /// Example: transcription.created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTranscriptionCreatedPayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription.created")]
        TranscriptionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTranscriptionCreatedPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTranscriptionCreatedPayloadEvent value)
        {
            return value switch
            {
                WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated => "transcription.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTranscriptionCreatedPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "transcription.created" => WebhookTranscriptionCreatedPayloadEvent.TranscriptionCreated,
                _ => null,
            };
        }
    }
}