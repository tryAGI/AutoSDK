//HintName: G.Models.ConversationItemInputAudioTranscriptionCompletedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemInputAudioTranscriptionCompletedPayloadType
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
    public static class ConversationItemInputAudioTranscriptionCompletedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemInputAudioTranscriptionCompletedPayloadType value)
        {
            return value switch
            {
                ConversationItemInputAudioTranscriptionCompletedPayloadType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemInputAudioTranscriptionCompletedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.completed" => ConversationItemInputAudioTranscriptionCompletedPayloadType.ConversationItemInputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}