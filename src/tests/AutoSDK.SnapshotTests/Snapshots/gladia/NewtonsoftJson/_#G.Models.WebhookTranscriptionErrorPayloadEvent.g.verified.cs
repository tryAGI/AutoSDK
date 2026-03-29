//HintName: G.Models.WebhookTranscriptionErrorPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transcription.error<br/>
    /// Example: transcription.error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTranscriptionErrorPayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription.error")]
        TranscriptionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTranscriptionErrorPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTranscriptionErrorPayloadEvent value)
        {
            return value switch
            {
                WebhookTranscriptionErrorPayloadEvent.TranscriptionError => "transcription.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTranscriptionErrorPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "transcription.error" => WebhookTranscriptionErrorPayloadEvent.TranscriptionError,
                _ => null,
            };
        }
    }
}