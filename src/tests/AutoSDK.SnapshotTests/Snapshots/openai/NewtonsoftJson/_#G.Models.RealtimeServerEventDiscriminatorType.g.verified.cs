//HintName: G.Models.RealtimeServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.created")]
        ConversationCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.created")]
        ConversationItemCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.deleted")]
        ConversationItemDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.completed")]
        ConversationItemInputAudioTranscriptionCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.delta")]
        ConversationItemInputAudioTranscriptionDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.input_audio_transcription.failed")]
        ConversationItemInputAudioTranscriptionFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.retrieved")]
        ConversationItemRetrieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation.item.truncated")]
        ConversationItemTruncated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.cleared")]
        InputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.committed")]
        InputAudioBufferCommitted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_started")]
        InputAudioBufferSpeechStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.speech_stopped")]
        InputAudioBufferSpeechStopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio_buffer.cleared")]
        OutputAudioBufferCleared,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio_buffer.started")]
        OutputAudioBufferStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio_buffer.stopped")]
        OutputAudioBufferStopped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limits.updated")]
        RateLimitsUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.delta")]
        ResponseAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.done")]
        ResponseAudioDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio_transcript.delta")]
        ResponseAudioTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio_transcript.done")]
        ResponseAudioTranscriptDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.added")]
        ResponseContentPartAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.done")]
        ResponseContentPartDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.created")]
        ResponseCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.done")]
        ResponseDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.delta")]
        ResponseFunctionCallArgumentsDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.done")]
        ResponseFunctionCallArgumentsDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.added")]
        ResponseOutputItemAdded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.done")]
        ResponseOutputItemDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.delta")]
        ResponseTextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.done")]
        ResponseTextDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.created")]
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.updated")]
        SessionUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription_session.updated")]
        TranscriptionSessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeServerEventDiscriminatorType.ConversationCreated => "conversation.created",
                RealtimeServerEventDiscriminatorType.ConversationItemCreated => "conversation.item.created",
                RealtimeServerEventDiscriminatorType.ConversationItemDeleted => "conversation.item.deleted",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta => "conversation.item.input_audio_transcription.delta",
                RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                RealtimeServerEventDiscriminatorType.ConversationItemRetrieved => "conversation.item.retrieved",
                RealtimeServerEventDiscriminatorType.ConversationItemTruncated => "conversation.item.truncated",
                RealtimeServerEventDiscriminatorType.Error => "error",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted => "output_audio_buffer.started",
                RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                RealtimeServerEventDiscriminatorType.RateLimitsUpdated => "rate_limits.updated",
                RealtimeServerEventDiscriminatorType.ResponseAudioDelta => "response.audio.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioDone => "response.audio.done",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta => "response.audio_transcript.delta",
                RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone => "response.audio_transcript.done",
                RealtimeServerEventDiscriminatorType.ResponseContentPartAdded => "response.content_part.added",
                RealtimeServerEventDiscriminatorType.ResponseContentPartDone => "response.content_part.done",
                RealtimeServerEventDiscriminatorType.ResponseCreated => "response.created",
                RealtimeServerEventDiscriminatorType.ResponseDone => "response.done",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded => "response.output_item.added",
                RealtimeServerEventDiscriminatorType.ResponseOutputItemDone => "response.output_item.done",
                RealtimeServerEventDiscriminatorType.ResponseTextDelta => "response.text.delta",
                RealtimeServerEventDiscriminatorType.ResponseTextDone => "response.text.done",
                RealtimeServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeServerEventDiscriminatorType.SessionUpdated => "session.updated",
                RealtimeServerEventDiscriminatorType.TranscriptionSessionUpdated => "transcription_session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => RealtimeServerEventDiscriminatorType.ConversationCreated,
                "conversation.item.created" => RealtimeServerEventDiscriminatorType.ConversationItemCreated,
                "conversation.item.deleted" => RealtimeServerEventDiscriminatorType.ConversationItemDeleted,
                "conversation.item.input_audio_transcription.completed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted,
                "conversation.item.input_audio_transcription.delta" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionDelta,
                "conversation.item.input_audio_transcription.failed" => RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed,
                "conversation.item.retrieved" => RealtimeServerEventDiscriminatorType.ConversationItemRetrieved,
                "conversation.item.truncated" => RealtimeServerEventDiscriminatorType.ConversationItemTruncated,
                "error" => RealtimeServerEventDiscriminatorType.Error,
                "input_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.InputAudioBufferCleared,
                "input_audio_buffer.committed" => RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted,
                "input_audio_buffer.speech_started" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted,
                "input_audio_buffer.speech_stopped" => RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped,
                "output_audio_buffer.cleared" => RealtimeServerEventDiscriminatorType.OutputAudioBufferCleared,
                "output_audio_buffer.started" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStarted,
                "output_audio_buffer.stopped" => RealtimeServerEventDiscriminatorType.OutputAudioBufferStopped,
                "rate_limits.updated" => RealtimeServerEventDiscriminatorType.RateLimitsUpdated,
                "response.audio.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioDelta,
                "response.audio.done" => RealtimeServerEventDiscriminatorType.ResponseAudioDone,
                "response.audio_transcript.delta" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta,
                "response.audio_transcript.done" => RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone,
                "response.content_part.added" => RealtimeServerEventDiscriminatorType.ResponseContentPartAdded,
                "response.content_part.done" => RealtimeServerEventDiscriminatorType.ResponseContentPartDone,
                "response.created" => RealtimeServerEventDiscriminatorType.ResponseCreated,
                "response.done" => RealtimeServerEventDiscriminatorType.ResponseDone,
                "response.function_call_arguments.delta" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta,
                "response.function_call_arguments.done" => RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone,
                "response.output_item.added" => RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded,
                "response.output_item.done" => RealtimeServerEventDiscriminatorType.ResponseOutputItemDone,
                "response.text.delta" => RealtimeServerEventDiscriminatorType.ResponseTextDelta,
                "response.text.done" => RealtimeServerEventDiscriminatorType.ResponseTextDone,
                "session.created" => RealtimeServerEventDiscriminatorType.SessionCreated,
                "session.updated" => RealtimeServerEventDiscriminatorType.SessionUpdated,
                "transcription_session.updated" => RealtimeServerEventDiscriminatorType.TranscriptionSessionUpdated,
                _ => null,
            };
        }
    }
}