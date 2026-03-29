//HintName: G.Models.WebhookTranscriptionSuccessPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transcription.success<br/>
    /// Example: transcription.success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTranscriptionSuccessPayloadEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription.success")]
        TranscriptionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTranscriptionSuccessPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTranscriptionSuccessPayloadEvent value)
        {
            return value switch
            {
                WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess => "transcription.success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTranscriptionSuccessPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "transcription.success" => WebhookTranscriptionSuccessPayloadEvent.TranscriptionSuccess,
                _ => null,
            };
        }
    }
}