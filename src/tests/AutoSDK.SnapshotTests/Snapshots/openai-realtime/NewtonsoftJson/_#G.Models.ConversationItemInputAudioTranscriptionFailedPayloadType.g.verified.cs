//HintName: G.Models.ConversationItemInputAudioTranscriptionFailedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemInputAudioTranscriptionFailedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.failed")]
        ConversationItemInputAudioTranscriptionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemInputAudioTranscriptionFailedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemInputAudioTranscriptionFailedPayloadType value)
        {
            return value switch
            {
                ConversationItemInputAudioTranscriptionFailedPayloadType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemInputAudioTranscriptionFailedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.failed" => ConversationItemInputAudioTranscriptionFailedPayloadType.ConversationItemInputAudioTranscriptionFailed,
                _ => null,
            };
        }
    }
}