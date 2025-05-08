//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `conversation.item.input_audio_transcription.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.delta")]
        ConversationItemInputAudioTranscriptionDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemInputAudioTranscriptionDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.delta" => RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType.ConversationItemInputAudioTranscriptionDelta,
                _ => null,
            };
        }
    }
}