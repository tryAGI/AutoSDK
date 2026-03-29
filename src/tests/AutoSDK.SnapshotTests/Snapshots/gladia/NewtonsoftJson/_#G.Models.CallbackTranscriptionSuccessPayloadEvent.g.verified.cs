//HintName: G.Models.CallbackTranscriptionSuccessPayloadEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of event<br/>
    /// Default Value: transcription.success<br/>
    /// Example: transcription.success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallbackTranscriptionSuccessPayloadEvent
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
    public static class CallbackTranscriptionSuccessPayloadEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackTranscriptionSuccessPayloadEvent value)
        {
            return value switch
            {
                CallbackTranscriptionSuccessPayloadEvent.TranscriptionSuccess => "transcription.success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackTranscriptionSuccessPayloadEvent? ToEnum(string value)
        {
            return value switch
            {
                "transcription.success" => CallbackTranscriptionSuccessPayloadEvent.TranscriptionSuccess,
                _ => null,
            };
        }
    }
}