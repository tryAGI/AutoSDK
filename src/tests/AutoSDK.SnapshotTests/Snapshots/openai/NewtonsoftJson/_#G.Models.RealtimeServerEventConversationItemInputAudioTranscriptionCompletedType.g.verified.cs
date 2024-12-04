//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be<br/>
    /// `conversation.item.input_audio_transcription.completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.completed")]
        ConversationItemInputAudioTranscriptionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}