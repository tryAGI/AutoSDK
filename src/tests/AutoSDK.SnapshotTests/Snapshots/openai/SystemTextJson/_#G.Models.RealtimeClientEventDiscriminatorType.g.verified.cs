//HintName: G.Models.RealtimeClientEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeClientEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreate,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDelete,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieve,
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncate,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferAppend,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferClear,
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommit,
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferClear,
        /// <summary>
        /// 
        /// </summary>
        ResponseCancel,
        /// <summary>
        /// 
        /// </summary>
        ResponseCreate,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeClientEventDiscriminatorType.ConversationItemCreate => "conversation.item.create",
                RealtimeClientEventDiscriminatorType.ConversationItemDelete => "conversation.item.delete",
                RealtimeClientEventDiscriminatorType.ConversationItemRetrieve => "conversation.item.retrieve",
                RealtimeClientEventDiscriminatorType.ConversationItemTruncate => "conversation.item.truncate",
                RealtimeClientEventDiscriminatorType.InputAudioBufferAppend => "input_audio_buffer.append",
                RealtimeClientEventDiscriminatorType.InputAudioBufferClear => "input_audio_buffer.clear",
                RealtimeClientEventDiscriminatorType.InputAudioBufferCommit => "input_audio_buffer.commit",
                RealtimeClientEventDiscriminatorType.OutputAudioBufferClear => "output_audio_buffer.clear",
                RealtimeClientEventDiscriminatorType.ResponseCancel => "response.cancel",
                RealtimeClientEventDiscriminatorType.ResponseCreate => "response.create",
                RealtimeClientEventDiscriminatorType.SessionUpdate => "session.update",
                RealtimeClientEventDiscriminatorType.TranscriptionSessionUpdate => "transcription_session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => RealtimeClientEventDiscriminatorType.ConversationItemCreate,
                "conversation.item.delete" => RealtimeClientEventDiscriminatorType.ConversationItemDelete,
                "conversation.item.retrieve" => RealtimeClientEventDiscriminatorType.ConversationItemRetrieve,
                "conversation.item.truncate" => RealtimeClientEventDiscriminatorType.ConversationItemTruncate,
                "input_audio_buffer.append" => RealtimeClientEventDiscriminatorType.InputAudioBufferAppend,
                "input_audio_buffer.clear" => RealtimeClientEventDiscriminatorType.InputAudioBufferClear,
                "input_audio_buffer.commit" => RealtimeClientEventDiscriminatorType.InputAudioBufferCommit,
                "output_audio_buffer.clear" => RealtimeClientEventDiscriminatorType.OutputAudioBufferClear,
                "response.cancel" => RealtimeClientEventDiscriminatorType.ResponseCancel,
                "response.create" => RealtimeClientEventDiscriminatorType.ResponseCreate,
                "session.update" => RealtimeClientEventDiscriminatorType.SessionUpdate,
                "transcription_session.update" => RealtimeClientEventDiscriminatorType.TranscriptionSessionUpdate,
                _ => null,
            };
        }
    }
}