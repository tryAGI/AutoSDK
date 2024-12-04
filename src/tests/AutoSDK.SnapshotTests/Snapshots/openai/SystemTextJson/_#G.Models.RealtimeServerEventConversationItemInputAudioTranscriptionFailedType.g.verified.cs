//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be<br/>
    /// `conversation.item.input_audio_transcription.failed`.
    /// </summary>
    public enum RealtimeServerEventConversationItemInputAudioTranscriptionFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemInputAudioTranscriptionFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemInputAudioTranscriptionFailedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemInputAudioTranscriptionFailedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed,
                _ => null,
            };
        }
    }
}